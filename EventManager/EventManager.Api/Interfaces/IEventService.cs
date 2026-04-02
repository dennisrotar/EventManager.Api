using EventManager.Api.Models;
using EventManager.Api.Models.DTOs;

namespace EventManager.Api.Interfaces;

public interface IEventService
{
	List<Event> GetAll();
	Event? GetById(Guid id);
	Event Create(CreateEventRequestDto dto);
	Event? Update(Guid id, UpdateEventRequestDto dto);
	bool Delete(Guid id);
}