using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebCoreMVC.Models;
using WebCoreMVC.ViewModels;

namespace WebCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebCoreMVCContext _dbContext;
        private readonly IWebHostEnvironment _webHostingEnvironment;

        public HomeController(WebCoreMVCContext dbContext, ILogger<HomeController> logger, IWebHostEnvironment webHostingEnvironment)
        {
            _logger = logger;
            _dbContext = dbContext;
            _webHostingEnvironment = webHostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Books
        public IActionResult Books(string searchString, string sortOrder, int? category, int currentPage = 1, int pageSize = 5)
        {

            #region search

            IQueryable<Book> books = _dbContext.BooksList.Include(x => x.Category);

            IQueryable<Category> categories = _dbContext.CategoriesList;

            
            if (category.HasValue)
            {
                books = books.Where(x => x.CategoryId == category);
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.NameOfBook.Contains(searchString)
                || s.Author.Contains(searchString)
                || s.Code.Contains(searchString));
            }

            #endregion

            #region Phần tử
            int totalItems = books.Count();
            int totalPages;
            if (totalItems / pageSize == 0)
            {
                totalPages = totalItems / pageSize;
            }
            else
            {
                totalPages = (totalItems / pageSize) + 1;
            }

            if (currentPage > totalPages)
            {
                currentPage = totalPages;
                if (currentPage == 0)
                {
                    currentPage = 1;
                }
            }
            #endregion

            #region Số trang trước sau
            int startPage = 1;
            int endPage = totalPages;
            int displayPage = 6;
            bool isOdd = displayPage % 2 != 0;
            int leftPage = displayPage / 2;
            int rightPage = displayPage / 2;

            if (!isOdd)
            {
                rightPage = (int)Math.Floor((decimal)displayPage / 2);
                leftPage = rightPage - 1;
            }

            if (currentPage <= startPage + leftPage)
            {
                endPage = startPage + (displayPage - 1);
            }
            else if (currentPage >= endPage - rightPage)
            {
                startPage = endPage - (displayPage - 1);
            }
            else
            {
                startPage = currentPage - leftPage;
                endPage = currentPage + rightPage;
            }

            if (endPage > totalPages)
            {
                endPage = totalPages;
            }

            if (startPage < 1)
            {
                startPage = 1;
            }
            #endregion

            #region Tạo Sắp Xếp Giá Trị 1 Thuộc Tính

            ViewBag.SortNameBook = String.IsNullOrEmpty(sortOrder) ? "name_desc" : string.Empty;

            ViewBag.SortAuthor = sortOrder == "author_asc" ? "author_desc" : "author_asc";
            ViewBag.SortYear = sortOrder == "year_asc" ? "year_desc" : "year_asc";
            ViewBag.SortCode = sortOrder == "code_asc" ? "code_desc" : "code_asc";
            ViewBag.SortQuantity = sortOrder == "quantity_asc" ? "quantity_desc" : "quantity_asc";
            ViewBag.SortCategory = sortOrder == "category_asc" ? "category_desc" : "category_asc";

            switch (sortOrder)
            {
                case "name_desc":
                    books = books.OrderByDescending(s => s.NameOfBook);
                    break;

                case "author_desc":
                    books = books.OrderByDescending(s => s.Author);
                    break;
                case "author_asc":
                    books = books.OrderBy(s => s.Author);
                    break;

                case "year_desc":
                    books = books.OrderByDescending(s => s.YearOfPrint);
                    break;
                case "year_asc":
                    books = books.OrderBy(s => s.YearOfPrint);
                    break;

                case "code_desc":
                    books = books.OrderByDescending(s => s.Code);
                    break;
                case "code_asc":
                    books = books.OrderBy(s => s.Code);
                    break;

                case "quantity_desc":
                    books = books.OrderByDescending(s => s.Quantity);
                    break;
                case "quantity_asc":
                    books = books.OrderBy(s => s.Quantity);
                    break;

                case "category_desc":
                    books = books.OrderByDescending(s => s.Category.CategoryName);
                    break;
                case "category_asc":
                    books = books.OrderBy(s => s.Category.CategoryName);
                    break;
                default:
                    books = books.OrderBy(s => s.NameOfBook);
                    break;
            }
            #endregion

            books = books.Skip((currentPage - 1) * pageSize)
                    .Take(pageSize);

            return View(new BookPageViewModel
            {
                Page = new PaginationViewModel
                {
                    CurrentPage = currentPage,
                    EndPage = endPage,
                    StartPage = startPage,
                    TotalPages = totalPages,
                    PageSize = pageSize
                },
                Books = BookViewModel.BookViews(books),

                Categories = CategoryViewModel.CategoryViews(categories),
            });
        }

        #region Create Book
        [HttpGet]
        public IActionResult CreateBook()
        {
            ViewBag.Categories = _dbContext.CategoriesList.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = $"{x.Id}",
            }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBook(CreateBookViewModel createBook, IFormFile image)
        {

            if (_dbContext.BooksList.Any(x => x.Code == createBook.Code))
            {
                ModelState.AddModelError(string.Empty, "Mã cuốn sách đã tồn tại trong kho");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _dbContext.CategoriesList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = $"{x.Id}",
                }).ToList();

                return View(createBook);
            }

            string uniqueFileName = null;
            if (createBook.Image != null)
            {
                string uploadsFolder = Path.Combine(_webHostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + createBook.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                createBook.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            _dbContext.BooksList.Add(new Book
            {
                Code = createBook.Code,
                Author = createBook.Author,
                CategoryId = createBook.CategoryId,
                NameOfBook = createBook.NameOfBook,
                Quantity = createBook.Quantity,
                YearOfPrint = createBook.YearOfPrint,
                ImageName = uniqueFileName,
            });

            _dbContext.SaveChanges();
            return RedirectToAction("Books");
        }
        #endregion

        #region Update Book
        [HttpGet]
        public IActionResult UpdateBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var currentBook = _dbContext.BooksList.FirstOrDefault(x => x.Id == id);

                ViewBag.Categories = _dbContext.CategoriesList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = $"{x.Id}",
                    Selected = currentBook.CategoryId == x.Id
                }).ToList();

                return View(new UpdateBookViewModel
                {
                    Id = currentBook.Id,
                    Code = currentBook.Code,
                    Author = currentBook.Author,
                    CategoryId = currentBook.CategoryId,
                    NameOfBook = currentBook.NameOfBook,
                    Quantity = currentBook.Quantity,
                    YearOfPrint = currentBook.YearOfPrint,
                    Photo = currentBook.ImageName,
                });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBook(int id, UpdateBookViewModel updateBook, IFormFile image)
        {
            var book = _dbContext.BooksList.Find(updateBook.Id);

            if (book == null)
            {
                ModelState.AddModelError(string.Empty, "Không có sách trong kho");
            }
            else if (book.Code == updateBook.Code)
            {
                string uniqueFileName = null;
                if (updateBook.Image != null)
                {
                    string uploadsFolder = Path.Combine(_webHostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + updateBook.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    updateBook.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                book.NameOfBook = updateBook.NameOfBook;
                book.Author = updateBook.Author;
                book.YearOfPrint = updateBook.YearOfPrint;
                book.CategoryId = updateBook.CategoryId;
                book.Quantity = updateBook.Quantity;
                book.ImageName = uniqueFileName;
            }
            else
            {
                book.Code = updateBook.Code;

                if (_dbContext.BooksList.Any(x => x.Code == updateBook.Code))
                {
                    ModelState.AddModelError(string.Empty, "Mã cuốn sách đã tồn tại trong kho");
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _dbContext.CategoriesList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = $"{x.Id}",
                    Selected = book.CategoryId == x.Id
                }).ToList();

                return View(updateBook);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Books");
        }
        #endregion

        #region Delete Book
        [HttpPost]
        public JsonResult AjaxDelete(int id)
        {
            _dbContext.Entry(new Book()
            {
                Id = id
            }).State = EntityState.Deleted;

            _dbContext.SaveChanges();

            return Json(true);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult DeleteMany(List<int> ids)
        {
            try
            {
                if (ids == null || ids.Count == 0)
                {
                    Response.StatusCode = 400;
                }
                else
                {
                    ids.ForEach(id => _dbContext.Entry(new Book
                    {
                        Id = id
                    }).State = EntityState.Deleted);

                    _dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                Response.StatusCode = 500;

            }

            return Json(string.Empty);
        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult DetailsBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var currentBook = _dbContext.BooksList.FirstOrDefault(x => x.Id == id);

                ViewBag.Categories = _dbContext.CategoriesList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = $"{x.Id}",
                    Selected = currentBook.CategoryId == x.Id
                }).ToList();

                return View(new DetailsBookViewModel
                {
                    Id = currentBook.Id,
                    Code = currentBook.Code,
                    Author = currentBook.Author,
                    CategoryId = currentBook.CategoryId,
                    NameOfBook = currentBook.NameOfBook,
                    Quantity = currentBook.Quantity,
                    YearOfPrint = currentBook.YearOfPrint,
                    Photo = currentBook.ImageName,
                });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetailsBook(int id, DetailsBookViewModel detailsBook)
        {
            var book = _dbContext.BooksList.Find(detailsBook.Id);

            if (book == null)
            {
                ModelState.AddModelError(string.Empty, "Không có sách trong kho");
            }
            else
            {
                book.Id = detailsBook.Id;
                book.NameOfBook = detailsBook.NameOfBook;
                book.Author = detailsBook.Author;
                book.YearOfPrint = detailsBook.YearOfPrint;
                book.CategoryId = detailsBook.CategoryId;
                book.Quantity = detailsBook.Quantity;
                book.Code = detailsBook.Code;
                book.ImageName = detailsBook.Photo;
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _dbContext.CategoriesList.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = $"{x.Id}",
                    Selected = book.CategoryId == x.Id
                }).ToList();

                return View(detailsBook);
            }

            return RedirectToAction("Books");
        }
        #endregion

        #endregion

        #region User
        public IActionResult Users(string searchString, string sortOrder, int currentPage = 1, int pageSize = 5)
        {

            #region search

            IQueryable<User> users = _dbContext.UsersList;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.UserName.Contains(searchString)
                || s.Email.Contains(searchString)
                || s.PhoneNumber.Contains(searchString));
            }

            #endregion

            #region Phần tử
            int totalItems = users.Count();
            int totalPages;
            if (totalItems / pageSize == 0)
            {
                totalPages = totalItems / pageSize;
            }
            else
            {
                totalPages = (totalItems / pageSize) + 1;
            }

            if (currentPage > totalPages)
            {
                currentPage = totalPages;
                if (currentPage == 0)
                {
                    currentPage = 1;
                }
            }
            #endregion

            #region Số trang trước sau
            int startPage = 1;
            int endPage = totalPages;
            int displayPage = 6;
            bool isOdd = displayPage % 2 != 0;
            int leftPage = displayPage / 2;
            int rightPage = displayPage / 2;

            if (!isOdd)
            {
                rightPage = (int)Math.Floor((decimal)displayPage / 2);
                leftPage = rightPage - 1;
            }

            if (currentPage <= startPage + leftPage)
            {
                endPage = startPage + (displayPage - 1);
            }
            else if (currentPage >= endPage - rightPage)
            {
                startPage = endPage - (displayPage - 1);
            }
            else
            {
                startPage = currentPage - leftPage;
                endPage = currentPage + rightPage;
            }

            if (endPage > totalPages)
            {
                endPage = totalPages;
            }

            if (startPage < 1)
            {
                startPage = 1;
            }
            #endregion

            #region Tạo Sắp Xếp Giá Trị 1 Thuộc Tính

            ViewBag.SortUserName = String.IsNullOrEmpty(sortOrder) ? "username_desc" : string.Empty;

            ViewBag.SortPhoneNumber = sortOrder == "phone_asc" ? "phone_asc" : "phone_asc";
            ViewBag.SortEmail = sortOrder == "email_desc" ? "email_desc" : "email_desc";
            ViewBag.SortDistrict = sortOrder == "district_asc" ? "district_asc" : "district_asc";
            ViewBag.SortAddress = sortOrder == "address_desc" ? "address_desc" : "address_desc";
            ViewBag.Sortprovince = sortOrder == "province_desc" ? "province_desc" : "province_desc";


            switch (sortOrder)
            {
                case "name_desc":
                    users = users.OrderByDescending(s => s.UserName);
                    break;

                case "phone_desc":
                    users = users.OrderByDescending(s => s.PhoneNumber);
                    break;
                case "phone_asc":
                    users = users.OrderBy(s => s.PhoneNumber);
                    break;

                case "email_desc":
                    users = users.OrderByDescending(s => s.Email);
                    break;
                case "email_asc":
                    users = users.OrderBy(s => s.Email);
                    break;

                case "address_desc":
                    users = users.OrderByDescending(s => s.Address);
                    break;
                case "address_asc":
                    users = users.OrderBy(s => s.Address);
                    break;

                case "province_desc":
                    users = users.OrderByDescending(s => s.Province);
                    break;
                case "province_asc":
                    users = users.OrderBy(s => s.Province);
                    break;

                case "category_desc":
                    users = users.OrderByDescending(s => s.District);
                    break;
                case "category_asc":
                    users = users.OrderByDescending(s => s.District);
                    break;
                default:
                    users = users.OrderBy(s => s.UserName);
                    break;
            }
            #endregion

            users = users.Skip((currentPage - 1) * pageSize)
                    .Take(pageSize);

            return View(new UserPageViewModel
            {
                Page = new PaginationViewModel
                {
                    CurrentPage = currentPage,
                    EndPage = endPage,
                    StartPage = startPage,
                    TotalPages = totalPages,
                    PageSize = pageSize
                },

                Users = UserViewModel.UserViews(users)
            });
        }

        #region Delete Book
        [HttpPost]
        public JsonResult AjaxDeleteUser(int id)
        {
            _dbContext.Entry(new User()
            {
                Id = id
            }).State = EntityState.Deleted;

            _dbContext.SaveChanges();

            return Json(true);
        }

        [HttpPost]
        public JsonResult DeleteManyUser(List<int> ids)
        {
            try
            {
                if (ids == null || ids.Count == 0)
                {
                    Response.StatusCode = 400;
                }
                else
                {
                    ids.ForEach(id => _dbContext.Entry(new User
                    {
                        Id = id
                    }).State = EntityState.Deleted);

                    _dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                Response.StatusCode = 500;

            }

            return Json(string.Empty);
        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult DetailsUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var currentUser = _dbContext.UsersList.FirstOrDefault(x => x.Id == id);
                
                return View(new DetailsUserViewModel
                {
                    Id = currentUser.Id,
                    UserName = currentUser.UserName,
                    PhoneNumber = currentUser.PhoneNumber,
                    Email = currentUser.Email,
                    Address = currentUser.Address,
                    Province = currentUser.Province,
                    District = currentUser.District,
                    FirstName = currentUser.FirstName,
                    LastName = currentUser.LastName,
                    Photo = currentUser.ImageName,
                });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetailsUser(int? id, DetailsUserViewModel detailsUser)
        {
            var user = _dbContext.UsersList.Find(detailsUser.Id);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Không có User");
            }
            else
            {
                user.Id = detailsUser.Id;
                user.UserName = detailsUser.UserName;
                user.PhoneNumber = detailsUser.PhoneNumber;
                user.Email = detailsUser.Email;
                user.LastName = detailsUser.LastName;
                user.FirstName = detailsUser.FirstName;
                user.Address = detailsUser.Address;
                user.Province = detailsUser.Province;
                user.District = detailsUser.District;
                user.ImageName = detailsUser.Photo;
            }

            if (!ModelState.IsValid)
            {
                return View(detailsUser);
            }

            return RedirectToAction("Users");
        }
        #endregion

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Province = _dbContext.Provinces.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            return View();
        }

        [HttpGet]
        public JsonResult GetDistricts(int provinceId)
        {
            var temp = _dbContext.Districts.Where(x => x.ProvinceId == provinceId).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            }).ToList();

            return Json(temp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(CreateUserViewModel createUser, int provinceId, IFormFile image)
        {
            IQueryable<Province> provinces = _dbContext.Provinces;
            IQueryable<District> districts = _dbContext.Districts;

            if (_dbContext.UsersList.Any(x => x.UserName == createUser.UserName))
            {
                ModelState.AddModelError(string.Empty, "Tên đăng nhập đã tồn tại");
            }

            if (_dbContext.UsersList.Any(x => x.Email == createUser.Email))
            {
                ModelState.AddModelError(string.Empty, "Email đã tồn tại");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Province = _dbContext.Provinces.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

                var temp = _dbContext.Districts.Where(x => x.ProvinceId == provinceId).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                }).ToList();
                return View(createUser);
            }

            string uniqueFileName = null;
            if (createUser.Image != null)
            {
                string uploadsFolder = Path.Combine(_webHostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + createUser.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                createUser.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            _dbContext.UsersList.Add(new User
            {
                UserName = createUser.UserName,
                PassWord = createUser.PassWord,
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                Address = createUser.Address,
                Province = createUser.Province,
                District = createUser.District,
                Birthday = createUser.Birthday,
                PhoneNumber = createUser.PhoneNumber,
                Email = createUser.Email,
                ImageName = uniqueFileName,

            });

            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion
    }
}
