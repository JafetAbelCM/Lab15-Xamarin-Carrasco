using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoREST.Models;

namespace TodoREST.Data
{
	public interface IRestService
	{
		Task<List<TodoItem>> RefreshDataAsync();

		Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

		Task DeleteTodoItemAsync(string id);
	}
}

