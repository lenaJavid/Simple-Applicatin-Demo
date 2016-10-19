/// <reference path="Module.js" />


app.service("myEmployeeService", function ($http)
{
    var urlBase = 'http://localhost:37490/api';

    //get All Eployee
    this.getEmployees = function () {
        //debugger;
        return $http.get(urlBase + "/EmployeeApi");
    };

    // get Employee By Id
    this.getEmployee = function (employeeID) {
        var response = $http({
            method: "GET",
            url: urlBase + "/EmployeeApi/" + employeeID,
            params: {
                id: JSON.stringify(employeeID)
            }
        });
        return response;
    }

    // Update Employee
    this.updateEmp = function (employeeID, employee) {
        var response = $http({
            method: "put",
            url: urlBase + "/EmployeeApi/" + employeeID,
            data: JSON.stringify(employee),
            dataType: "json"
        });
        return response;
    }

    // Add Employee
    this.AddEmp = function (employee) {
        var response = $http({
            method: "post",
            url: urlBase + "/EmployeeApi/",
            data: JSON.stringify(employee),
            dataType: "json"
        });
        return response;
    }

    //Delete Employee
    this.DeleteEmp = function (employeeId) {
        var response = $http({
            method: "post",
            url: urlBase + "/EmployeeApi/" + employeeId,
            params: {
                employeeId: JSON.stringify(employeeId)
            }
        });
        return response;
    }
});