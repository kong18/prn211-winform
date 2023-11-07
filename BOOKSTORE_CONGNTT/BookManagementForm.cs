using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using Repositories.Entities;
using Repositories.Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKSTORE_CONGNTT
{
    public partial class BookManagementForm : Form
    {
        private BookManagement2023DbContext context = new();
        private BookService bookService = new();
        public int Role { get; set; }
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            dataGridView1.DataSource = context.Books.Include(x => x.BookCategory).Select(x => new
            {
                x.BookId,
                x.BookName,
                x.Quantity,
                x.Description,
                x.Price,
                x.Author,
                x.ReleaseDate,
                x.BookCategory,
                x.BookCategory.BookGenreType

            }).ToList();
            cboBookCategoryId.DataSource = context.BookCategories.Select(x => new
            {
                x.BookCategoryId,
                x.BookGenreType
            }).ToList();
            cboBookCategoryId.DisplayMember = "BookGenreType";
            cboBookCategoryId.ValueMember = "BookCategoryId";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            DialogResult dialog = MessageBox.Show($"Are you sure you want to delte this product: {id}", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                bookService.DeleteBook(id);

                dataGridView1.DataSource = null;
                LoadInfo();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewProduct(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                txtDescription.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtAuthor.Text = row.Cells[5].Value.ToString();
                dtpReleaseDate.Text = row.Cells[6].Value.ToString();
                cboBookCategoryId.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;

            var searchValue = bookService.searchByName(keyword);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchValue.Select(x => new
            {
                x.BookId,
                x.BookName,
                x.Quantity,
                x.Description,
                x.Price,
                x.Author,
                x.ReleaseDate,
                x.BookCategory,
                x.BookCategory.BookGenreType
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the ID is duplicated
            int newBookId = int.Parse(txtId.Text);

            if (bookService.IsIdDuplicated(newBookId))
            {
                MessageBox.Show("ID is duplicated");
            }
            else
            {
                // Create a new Book object and set its properties
                Book newBook = new Book
                {
                    BookId = newBookId,
                    BookName = txtName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text,
                    Price = double.Parse(txtPrice.Text),
                    Author = txtAuthor.Text,
                    ReleaseDate = dtpReleaseDate.Value,
                    BookCategoryId = (int)cboBookCategoryId.SelectedValue
                };

                // Add the new book to the context and save changes
                context.Books.Add(newBook);
                context.SaveChanges();

                // Reload the data
                dataGridView1.DataSource = null;
                LoadInfo();
            }
        }
    }
}
