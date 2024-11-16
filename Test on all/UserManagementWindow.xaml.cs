using System;
using System.Collections.Generic;
using System.Windows;

namespace Test_on_all
{
    public partial class UserManagementWindow : Window
    {
        public UserManagementWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Example data binding
            UsersGrid.ItemsSource = GetUsers();
        }

        private List<object> GetUsers()
        {
            // Dummy data for demonstration
            return new List<object>
            {
                new { UserID = 1, Name = "Employee 1", Email = "employee1@example.com", Role = "Employee" },
                new { UserID = 2, Name = "Employee 2", Email = "employee2@example.com", Role = "Employee" }
            };
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic for adding a task
            var newTask = new { TaskID = 3, Title = "New Task", Description = "New Task Description", Status = "Pending", DueDate = DateTime.Now.AddDays(7) };

            // Here, you would typically add the new task to your database
            // For example, using Entity Framework:
            // dbContext.Tasks.Add(new Task { Title = "New Task", Description = "New Task Description", Status = "Pending", DueDate = DateTime.Now.AddDays(7), UserID = selectedUserID });
            // dbContext.SaveChanges();

            // Refresh the data grid
            UsersGrid.ItemsSource = GetTasksForUser(selectedUserID);
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic for deleting a task
            if (UsersGrid.SelectedItem is not null)
            {
                var selectedTask = UsersGrid.SelectedItem;

                // Here, you would typically delete the task from your database
                // For example, using Entity Framework:
                // dbContext.Tasks.Remove(selectedTask);
                // dbContext.SaveChanges();

                // Refresh the data grid
                UsersGrid.ItemsSource = GetTasksForUser(selectedUserID);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void UpdateTaskButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic for updating a task
            if (UsersGrid.SelectedItem is not null)
            {
                var selectedTask = UsersGrid.SelectedItem;

                // Here, you would typically update the task in your database
                // For example, using Entity Framework:
                // var taskToUpdate = dbContext.Tasks.Find(selectedTask.TaskID);
                // taskToUpdate.Status = "Completed"; // Or any other updates
                // dbContext.SaveChanges();

                // Refresh the data grid
                UsersGrid.ItemsSource = GetTasksForUser(selectedUserID);
            }
            else
            {
                MessageBox.Show("Please select a task to update.");
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic for logging out
            this.Close();
        }

        private IEnumerable<object> GetTasksForUser(int userID)
        {
            // Retrieve tasks for the specified user from the database
            // For example, using Entity Framework:
            // return dbContext.Tasks.Where(task => task.UserID == userID).ToList();

            // Dummy data for demonstration
            return new List<object>
            {
                new { TaskID = 1, Title = "Task 1", Description = "Description 1", Status = "Pending", DueDate = DateTime.Now.AddDays(1) },
                new { TaskID = 2, Title = "Task 2", Description = "Description 2", Status = "In Progress", DueDate = DateTime.Now.AddDays(2) }
            };
        }

        private int selectedUserID = 1; // This should be set based on the selected user in your application
    }
}
