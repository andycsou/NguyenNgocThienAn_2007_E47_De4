using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenNgocThienAn_2007_E47_De4.Models;

namespace NguyenNgocThienAn_2007_E47_De4.Controllers
{
    public class KhachHangController : Controller
    {
        QuanLyBanHangDataContext da = new QuanLyBanHangDataContext();

        // GET: KhachHang
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCustomer()
        {
            //c1. giam dan theo ten quoc gia
            var ds = da.Customers.OrderByDescending(s => s.Country).ToList();
            return View(ds);
        }

        public ActionResult Details(string id)
        {
            Customer c = da.Customers.FirstOrDefault(g => g.CustomerID == id);
            return View(c);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHang/Create
        [HttpPost]
        public ActionResult Create(Customer customer, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //tao kh
                Customer c = new Customer();
                //gan thuoc tinh cho kh
                c = customer;
                c.CustomerID = customer.CustomerID;
                c.CompanyName = customer.CompanyName;
                c.ContactName = customer.ContactName;
                c.ContactTitle = customer.ContactTitle;
                c.Address = customer.Address;
                c.City = customer.City;
                c.Region = customer.Region;
                c.PostalCode = customer.PostalCode;
                c.Country = customer.Country;
                c.Phone = customer.Phone;
                c.Fax = customer.Fax;
                //them vao bang c
                da.Customers.InsertOnSubmit(c);
                //luu db
                da.SubmitChanges();
                //goi hien thi kh
                return RedirectToAction("ListCustomer");
            }
            catch
            {
                return View();
            }
        }

        //tao 1 view chua thong tin kh can sua
        // GET: KhachHang/Edit/5
        public ActionResult Edit(string id)
        {
            Customer c = da.Customers.FirstOrDefault(s => s.CustomerID == id);
            return View(c);
        }
        //thuc hien sua
        // POST: khachhang/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer customer, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //lay kh mun sua
                Customer c = da.Customers.First(s => s.CustomerID == customer.CustomerID);
                //gan thuoc tinh moi cho khach
                c.CustomerID = customer.CustomerID;
                c.CompanyName = customer.CompanyName;
                c.ContactName = customer.ContactName;
                c.ContactTitle = customer.ContactTitle;
                c.Address = customer.Address;
                c.City = customer.City;
                c.Region = customer.Region;
                c.PostalCode = customer.PostalCode;
                c.Country = customer.Country;
                c.Phone = customer.Phone;
                c.Fax = customer.Fax;
                //luu db
                da.SubmitChanges();
                //goi hien thi sp
                return RedirectToAction("ListCustomer");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult TinhDoanhSo(string id)
        {

            var customer = da.Customers.FirstOrDefault(c => c.CustomerID == id);

            var orderDetails = da.OrderDetails.Where(od => od.Order.CustomerID == id).ToList(); // lay ds oddts
            var totalSales = orderDetails.Any() ? orderDetails.Sum(od => od.Quantity * od.UnitPrice) : 0;

            var viewModel = new ThongKeDoanhSoViewModel
            {
                MaKhachHang = customer.CustomerID,
                TenCongTy = customer.CompanyName,
                TongDoanhSo = totalSales
            };

            return View(viewModel);

        }

        public ActionResult DemSLSP(string id)
        {   
            var customer = da.Customers.FirstOrDefault(c => c.CustomerID == id);
            var orderDetails = customer.Orders.SelectMany(o => o.OrderDetails).ToList();
            var totalProductCount = orderDetails.Any() ? orderDetails.Sum(od => od.Quantity) : 0;

            var viewModel = new ThongKeSanPhamViewModel
            {
                MaKhachHang = customer.CustomerID,
                TenCongTy = customer.CompanyName,
                TongSanPham = totalProductCount
            };

            return View(viewModel); 
        }
    }
}