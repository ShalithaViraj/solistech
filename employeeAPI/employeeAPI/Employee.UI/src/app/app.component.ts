import { Component } from '@angular/core';
import { Employee } from './models/employee';
import { EmployeeService } from './services/employee.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Employee.UI';

  employees: Employee[] = [];

  updatesemp?: Employee;

  constructor(private employeeService: EmployeeService) {}

    ngOnInit() : void{
    
      this.employeeService
      .getemployee()
      .subscribe((result:Employee[])=>(this.employees=result));

    }

    updatedEmployeeList(employees: Employee[]){
      this.employees = employees;
    }

    initNewEmployee(){
      this.updatesemp = new Employee();
    }

    editEmployee(employee: Employee){
      this.updatesemp = employee;
    }
  

}
