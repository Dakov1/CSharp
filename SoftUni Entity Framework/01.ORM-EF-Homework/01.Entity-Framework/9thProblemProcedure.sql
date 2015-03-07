IF OBJECT_ID ('udp_FindAllProjectsForEmployee') IS NOT NULL
   DROP PROCEDURE udp_FindAllProjectsForEmployee
GO
CREATE PROCEDURE udp_FindAllProjectsForEmployee(@FirstName NVARCHAR(MAX), @LastName NVARCHAR(MAX))
AS
	SELECT p.Name as [Project Name]
	FROM Employees e
	JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID
	JOIN Projects p ON ep.ProjectID = p.ProjectID
	WHERE e.FirstName = @FirstName AND e.LastName = @LastName
GO
