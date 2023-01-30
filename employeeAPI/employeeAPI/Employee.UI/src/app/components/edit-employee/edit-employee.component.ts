import { outputAst } from '@angular/compiler';
import { Component, Input, OnInit,Output, EventEmitter } from '@angular/core';
import { Employee } from 'src/app/models/employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {
 
  @Input() employee?: Employee;
  @Output() employeeupdate = new EventEmitter<Employee[]>(); 

  constructor(private employeeService: EmployeeService){

  }
  massage: boolean = false;
  ngOnInit(): void{  }

  updateemployee(employee: Employee)
  {
    this.employeeService
    .updateemployee(employee)
    .subscribe((employees: Employee[]) => this.employeeupdate.emit(employees));
  }
  
  Deleteemployee(employee: Employee){this.employeeService
    .deleteemployee(employee)
    .subscribe((employees: Employee[]) => this.employeeupdate.emit(employees));
  }

  Createemployee(employee: Employee)
  {
    this.employeeService
    .createemployee(employee)
    .subscribe((employees: Employee[]) => this.employeeupdate.emit(employees))
    .add(() => this.massage = true);
    }
   
    removeMassage(){
      this.massage = false;
   }
}

