import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';
import { AuthenticationService } from '../_services';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})

export class RegisterComponent implements OnInit {
  public registerForm!: FormGroup;
  public loading = false;
  public submitted = false; 
  
  constructor(
    private formBuilder: FormBuilder,
    private authentication: AuthenticationService
  ) { }
  
  public get formFields(): { [key: string]: AbstractControl} { 
    return this.registerForm.controls 
  };

  public onSubmit() : void {
    this.submitted = true;
    if (this.registerForm.invalid) {
      console.log("Register form invalid");
      return;
    }
    this.loading = true;
    this.authentication.register(
      this.formFields.username.value,
      this.formFields.password.value)
      .subscribe(registerData => console.log(registerData));
    console.log("Register form submitted");
  }
  
  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      username: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }
}
