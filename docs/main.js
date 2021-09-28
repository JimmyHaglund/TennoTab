(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "/1go":
/*!**********************************************!*\
  !*** ./src/app/_interfaces/obtainedState.ts ***!
  \**********************************************/
/*! exports provided: obtainedState */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "obtainedState", function() { return obtainedState; });
const obtainedState = {
    Any: "All",
    NotObtained: "Not Obtained",
    Obtained: "Obtained",
    Mastered: "Mastered"
};


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! D:\Projects\WarframeProgressTracker\Managed\Application\warframe-progress-tracker\src\main.ts */"zUnb");


/***/ }),

/***/ "1W4x":
/*!************************************************!*\
  !*** ./src/app/register/register.component.ts ***!
  \************************************************/
/*! exports provided: RegisterComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RegisterComponent", function() { return RegisterComponent; });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/forms */ "3Pt+");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../_services */ "J9tS");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "ofXK");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "tyNb");






function RegisterComponent_div_7_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "First Name is required");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function RegisterComponent_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 14);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, RegisterComponent_div_7_div_1_Template, 2, 0, "div", 15);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r0.formFields.firstName.errors.required);
} }
function RegisterComponent_div_12_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Last Name is required");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function RegisterComponent_div_12_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 14);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, RegisterComponent_div_12_div_1_Template, 2, 0, "div", 15);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r1 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r1.formFields.lastName.errors.required);
} }
function RegisterComponent_div_17_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Username is required");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function RegisterComponent_div_17_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 14);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, RegisterComponent_div_17_div_1_Template, 2, 0, "div", 15);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r2 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r2.formFields.username.errors.required);
} }
function RegisterComponent_div_22_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Password is required");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function RegisterComponent_div_22_div_2_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Password must be at least 6 characters");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function RegisterComponent_div_22_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 14);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, RegisterComponent_div_22_div_1_Template, 2, 0, "div", 15);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](2, RegisterComponent_div_22_div_2_Template, 2, 0, "div", 15);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r3 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r3.formFields.password.errors.required);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r3.formFields.password.errors.minlength);
} }
function RegisterComponent_span_25_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](0, "span", 16);
} }
const _c0 = function (a0) { return { "is-invalid": a0 }; };
class RegisterComponent {
    constructor(formBuilder, authentication) {
        this.formBuilder = formBuilder;
        this.authentication = authentication;
        this.loading = false;
        this.submitted = false;
    }
    get formFields() {
        return this.registerForm.controls;
    }
    ;
    onSubmit() {
        this.submitted = true;
        if (this.registerForm.invalid) {
            console.log("Register form invalid");
            return;
        }
        this.loading = true;
        this.authentication.register(this.formFields.username.value, this.formFields.password.value)
            .subscribe(registerData => console.log(registerData));
        console.log("Register form submitted");
    }
    ngOnInit() {
        this.registerForm = this.formBuilder.group({
            firstName: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].required],
            lastName: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].required],
            username: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].required],
            password: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].minLength(6)]]
        });
    }
}
RegisterComponent.ɵfac = function RegisterComponent_Factory(t) { return new (t || RegisterComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_0__["FormBuilder"]), _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_2__["AuthenticationService"])); };
RegisterComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: RegisterComponent, selectors: [["app-register"]], decls: 29, vars: 19, consts: [[3, "formGroup", "ngSubmit"], [1, "form-group"], ["for", "firstName"], ["type", "text", "formControlName", "firstName", 1, "form-control", 3, "ngClass"], ["class", "invalid-feedback", 4, "ngIf"], ["for", "lastName"], ["type", "text", "formControlName", "lastName", 1, "form-control", 3, "ngClass"], ["for", "username"], ["type", "text", "formControlName", "username", 1, "form-control", 3, "ngClass"], ["for", "password"], ["type", "password", "formControlName", "password", 1, "form-control", 3, "ngClass"], [1, "btn", "btn-primary", 3, "disabled"], ["class", "spinner-border spinner-border-sm mr-1", 4, "ngIf"], ["routerLink", "/login", 1, "btn", "btn-link"], [1, "invalid-feedback"], [4, "ngIf"], [1, "spinner-border", "spinner-border-sm", "mr-1"]], template: function RegisterComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "h2");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Register");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "form", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("ngSubmit", function RegisterComponent_Template_form_ngSubmit_2_listener() { return ctx.onSubmit(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](3, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "label", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](5, "First Name");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](6, "input", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](7, RegisterComponent_div_7_Template, 2, 1, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](9, "label", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](10, "Last Name");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](11, "input", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](12, RegisterComponent_div_12_Template, 2, 1, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](13, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "label", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](15, "Username");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](16, "input", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](17, RegisterComponent_div_17_Template, 2, 1, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](18, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](19, "label", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](20, "Password");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](21, "input", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](22, RegisterComponent_div_22_Template, 3, 2, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](23, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](24, "button", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](25, RegisterComponent_span_25_Template, 1, 0, "span", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](26, " Register ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](27, "a", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](28, "Cancel");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("formGroup", ctx.registerForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](11, _c0, ctx.submitted && ctx.formFields.firstName.errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.submitted && ctx.formFields.firstName.errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](13, _c0, ctx.submitted && ctx.formFields.lastName.errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.submitted && ctx.formFields.lastName.errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](15, _c0, ctx.submitted && ctx.formFields.username.errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.submitted && ctx.formFields.username.errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](17, _c0, ctx.submitted && ctx.formFields.password.errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.submitted && ctx.formFields.password.errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("disabled", ctx.loading);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.loading);
    } }, directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_0__["ɵangular_packages_forms_forms_ba"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["NgControlStatusGroup"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["FormGroupDirective"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["DefaultValueAccessor"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["NgControlStatus"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["FormControlName"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgClass"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgIf"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterLinkWithHref"]], styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJyZWdpc3Rlci5jb21wb25lbnQuc2NzcyJ9 */"] });


/***/ }),

/***/ "1lYs":
/*!*********************************************************************************************!*\
  !*** ./src/app/_components/collectibles/collectible-filter/collectible-filter.component.ts ***!
  \*********************************************************************************************/
/*! exports provided: CollectibleFilterComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectibleFilterComponent", function() { return CollectibleFilterComponent; });
/* harmony import */ var _interfaces__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../_interfaces */ "rGDM");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ofXK");



function CollectibleFilterComponent_div_10_Template(rf, ctx) { if (rf & 1) {
    const _r5 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("click", function CollectibleFilterComponent_div_10_Template_div_click_1_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵrestoreView"](_r5); const category_r3 = ctx.$implicit; const ctx_r4 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"](); return ctx_r4.toggleShowCategory(category_r3.value); });
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "div", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](3, "input", 10);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](4);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const category_r3 = ctx.$implicit;
    const ctx_r1 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("checked", ctx_r1.getCheckedValue(category_r3.value));
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"](" ", category_r3.value, "s ");
} }
function CollectibleFilterComponent_div_15_Template(rf, ctx) { if (rf & 1) {
    const _r8 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div", 11);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("click", function CollectibleFilterComponent_div_15_Template_div_click_1_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵrestoreView"](_r8); const state_r6 = ctx.$implicit; const ctx_r7 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"](); return ctx_r7.setObtainedFilter(state_r6.value); });
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "div", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](3, "input", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](4);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const state_r6 = ctx.$implicit;
    const ctx_r2 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("checked", ctx_r2.getObtainedFilterValue(state_r6.value));
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"](" ", state_r6.value, " ");
} }
class CollectibleFilterComponent {
    constructor() {
        this.categories = _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"];
        this.obtainedStates = _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"];
        this._filterState = {
            filterText: "",
            allowedObtainedState: _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].NotObtained,
            includedCategories: {}
        };
        this.sortByDefinitionOrder = (a, b) => {
            return 0;
        };
    }
    ngOnInit() {
        this.initialiseShownCategories();
    }
    update() {
        this.filter.filter = this._filterState;
    }
    toggleShowCategory(categoryName) {
        let shownCategories = this._filterState.includedCategories;
        shownCategories[categoryName] = !shownCategories[categoryName];
        this.update();
    }
    setFilterText(value) {
        this._filterState.filterText = value;
        this.update();
    }
    initialiseShownCategories() {
        for (let key in _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"]) {
            let category = _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"][key];
            this._filterState.includedCategories[category] = true;
        }
        this.update();
    }
    setObtainedFilterToAny() {
        this._filterState.allowedObtainedState = _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].Any;
    }
    setObtainedFilterToNonObtained() {
        this._filterState.allowedObtainedState = _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].NotObtained;
    }
    setObtainedFilterToObtained() {
        this._filterState.allowedObtainedState = _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].Obtained;
    }
    setObtainedFilterToMastered() {
        this._filterState.allowedObtainedState = _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].Mastered;
    }
    getCheckedValue(category) {
        return this._filterState.includedCategories[category];
    }
    setObtainedFilter(value) {
        this._filterState.allowedObtainedState = value;
    }
    getObtainedFilterValue(rank) {
        return this._filterState.allowedObtainedState === rank;
    }
}
CollectibleFilterComponent.ɵfac = function CollectibleFilterComponent_Factory(t) { return new (t || CollectibleFilterComponent)(); };
CollectibleFilterComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: CollectibleFilterComponent, selectors: [["app-collectible-filter"]], inputs: { filter: "filter" }, decls: 17, vars: 7, consts: [[1, "container"], [1, "row"], [1, "col-12"], ["type", "text", 1, "w-100", 3, "input"], ["searchBox", ""], ["class", "col-12 col-sm-6 col-lg-12", 4, "ngFor", "ngForOf"], [1, "center"], [1, "col-12", "col-sm-6", "col-lg-12"], [1, "category-toggle-container", "noselect", "btn", "btn-primary", 3, "click"], [1, "category-toggle", "nopointer"], ["type", "checkbox", 3, "checked"], [1, "btn", "btn-primary", "category-toggle-container", 3, "click"], ["type", "radio", 3, "checked"]], template: function CollectibleFilterComponent_Template(rf, ctx) { if (rf & 1) {
        const _r9 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵgetCurrentView"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "h5");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](3, "Search");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](5, "input", 3, 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("input", function CollectibleFilterComponent_Template_input_input_5_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵrestoreView"](_r9); const _r0 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵreference"](6); return ctx.setFilterText(_r0.value); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](7, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "h5");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](9, "Included categories");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](10, CollectibleFilterComponent_div_10_Template, 5, 2, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpipe"](11, "keyvalue");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](12, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](13, "h5", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](14, "Obtained filter");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](15, CollectibleFilterComponent_div_15_Template, 5, 2, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpipe"](16, "keyvalue");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngForOf", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpipeBind1"](11, 2, ctx.categories));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngForOf", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpipeBind2"](16, 4, ctx.obtainedStates, ctx.sortByDefinitionOrder));
    } }, directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["NgForOf"]], pipes: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["KeyValuePipe"]], styles: [".category-toggle-container[_ngcontent-%COMP%] {\n  position: relative;\n  height: 2em;\n  cursor: pointer;\n  margin: 3px 0px 3px;\n  width: 100%;\n  transition: 0s;\n}\n\n.category-toggle[_ngcontent-%COMP%] {\n  position: absolute;\n  left: 10px;\n  top: 50%;\n  transform: translateY(-50%);\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFwuLlxcY29sbGVjdGlibGUtZmlsdGVyLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0csa0JBQUE7RUFDQSxXQUFBO0VBQ0EsZUFBQTtFQUNBLG1CQUFBO0VBQ0EsV0FBQTtFQUNBLGNBQUE7QUFDSDs7QUFFQTtFQUNHLGtCQUFBO0VBQ0EsVUFBQTtFQUNBLFFBQUE7RUFDQSwyQkFBQTtBQUNIIiwiZmlsZSI6ImNvbGxlY3RpYmxlLWZpbHRlci5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi5jYXRlZ29yeS10b2dnbGUtY29udGFpbmVyIHtcclxuICAgcG9zaXRpb246IHJlbGF0aXZlO1xyXG4gICBoZWlnaHQ6IDJlbTtcclxuICAgY3Vyc29yOnBvaW50ZXI7XHJcbiAgIG1hcmdpbjogM3B4IDBweCAzcHg7XHJcbiAgIHdpZHRoOiAxMDAlO1xyXG4gICB0cmFuc2l0aW9uOiAwcztcclxufVxyXG5cclxuLmNhdGVnb3J5LXRvZ2dsZSB7XHJcbiAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcclxuICAgbGVmdDogMTBweDtcclxuICAgdG9wOjUwJTtcclxuICAgdHJhbnNmb3JtOiB0cmFuc2xhdGVZKC01MCUpO1xyXG59Il19 */"] });


/***/ }),

/***/ "1s4E":
/*!**********************************************************************************!*\
  !*** ./src/app/_components/wish-list/item-cost-card/item-cost-card.component.ts ***!
  \**********************************************************************************/
/*! exports provided: ItemCostCardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ItemCostCardComponent", function() { return ItemCostCardComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../_services */ "J9tS");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "tyNb");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "ofXK");




function ItemCostCardComponent_div_17_span_4_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "span", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const resource_r2 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate2"](" ", resource_r2.name, " (", resource_r2.amount, ") ");
} }
function ItemCostCardComponent_div_17_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h5");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Resource costs");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](4, ItemCostCardComponent_div_17_span_4_Template, 2, 2, "span", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](4);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx_r0.getBlueprintResourceCost());
} }
class ItemCostCardComponent {
    constructor(collectibleService) {
        this.collectibleService = collectibleService;
    }
    ngOnInit() { }
    getBlueprintComponents() {
        if (this.blueprint === undefined)
            return [];
        let blueprint = this.blueprint;
        return blueprint === undefined ? [] : blueprint.components;
    }
    getBlueprintResourceCost() {
        if (this.cost === undefined)
            return [];
        return this.cost.cost;
    }
    getStatusText() {
        const collectible = this.collectible;
        return collectible.mastered ? "Mastered" :
            collectible.obtained ? "Obtained" : "Not obtained";
    }
    hasResourceCost() {
        return this.getBlueprintResourceCost().length > 0;
    }
    increaseRank() {
        if (!this.collectible.obtained) {
            this.collectible.obtained = true;
        }
        else if (!this.collectible.mastered) {
            this.collectible.mastered = true;
        }
        else
            return;
        this.updateCollectible();
    }
    reduceRank() {
        if (this.collectible.mastered) {
            this.collectible.mastered = false;
        }
        else if (this.collectible.obtained) {
            this.collectible.obtained = false;
        }
        else
            return;
        this.updateCollectible();
    }
    removeFromWishlist() {
        console.log("Removing collectible", this.collectible.name, " from wishlist");
        this.collectible.onWishlist = false;
        this.updateCollectible();
        if (this.onDelete !== undefined)
            this.onDelete(this.collectible.name);
    }
    updateCollectible() {
        this.collectibleService.updateCollectible(this.collectible)
            .subscribe(() => { });
    }
}
ItemCostCardComponent.ɵfac = function ItemCostCardComponent_Factory(t) { return new (t || ItemCostCardComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_1__["CollectibleService"])); };
ItemCostCardComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: ItemCostCardComponent, selectors: [["app-item-cost-card"]], inputs: { blueprint: "blueprint", collectible: "collectible", cost: "cost", onDelete: "onDelete" }, decls: 18, vars: 5, consts: [[1, "d-flex", "border-bottom", "justify-content-between"], [1, "d-flex"], [3, "routerLink"], [1, "m-1"], [1, "btn", "btn-primary", "m-1", "fs-1", 3, "click"], [1, "btn", "btn-warning", "m-1", "fs-1", 3, "click"], [4, "ngIf"], ["class", "component-box m-1", 4, "ngFor", "ngForOf"], [1, "component-box", "m-1"]], template: function ItemCostCardComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "a", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](4, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "h4");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "h4");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](9);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](10, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "button", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function ItemCostCardComponent_Template_button_click_11_listener() { return ctx.reduceRank(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](12, "-");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](13, "button", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function ItemCostCardComponent_Template_button_click_13_listener() { return ctx.increaseRank(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](14, "+");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](15, "button", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function ItemCostCardComponent_Template_button_click_15_listener() { return ctx.removeFromWishlist(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, "X");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](17, ItemCostCardComponent_div_17_Template, 5, 1, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpropertyInterpolate2"]("routerLink", "/collectible/", ctx.collectible.category, "/", ctx.collectible.name, "");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](ctx.collectible.name);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"](" Status: ", ctx.getStatusText(), " ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngIf", ctx.hasResourceCost());
    } }, directives: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterLinkWithHref"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgIf"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgForOf"]], styles: [".item-cost-card[_ngcontent-%COMP%]:hover {\n  background-color: honeydew;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFwuLlxcaXRlbS1jb3N0LWNhcmQuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRywwQkFBQTtBQUNIIiwiZmlsZSI6Iml0ZW0tY29zdC1jYXJkLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLml0ZW0tY29zdC1jYXJkOmhvdmVyIHtcclxuICAgYmFja2dyb3VuZC1jb2xvcjogaG9uZXlkZXc7XHJcbn0iXX0= */"] });


/***/ }),

/***/ "4FHd":
/*!************************************************!*\
  !*** ./src/app/_services/blueprint.service.ts ***!
  \************************************************/
/*! exports provided: BlueprintService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "BlueprintService", function() { return BlueprintService; });
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! rxjs */ "qCKp");
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/environments/environment */ "AytR");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs/operators */ "kU1M");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "tk/3");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../message.service */ "OdHV");






class BlueprintService {
    constructor(http, messageService) {
        this.http = http;
        this.messageService = messageService;
        this._apiAddress = src_environments_environment__WEBPACK_IMPORTED_MODULE_1__["environment"].apiUrl + "/blueprint";
    }
    getSource(itemName) {
        let data = { name: itemName };
        return this.http.put(src_environments_environment__WEBPACK_IMPORTED_MODULE_1__["environment"].apiUrl + "/collectible/getsource", data)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["catchError"])(this.handleError('getSource')));
    }
    getBlueprintsWithResult(resultName) {
        let data = { ResultName: resultName };
        return this.http.put(this._apiAddress + "/components", data)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["catchError"])(this.handleError('getBlueprintWithResult')));
        // results.subscribe((result => console.log(result)));
    }
    getTotalResourceCost(resultName) {
        let data = { ResultName: resultName };
        return this.http.put(this._apiAddress + "/totalresourcecost", data)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["catchError"])(this.handleError('getTotalResourceCost')));
    }
    handleError(operation = 'operation', result) {
        return (error) => {
            console.error(error); // log to console instead
            this.log(`${operation} failed: ${error.message}`);
            return Object(rxjs__WEBPACK_IMPORTED_MODULE_0__["of"])(result);
        };
    }
    log(message) {
        this.messageService.add(`FrameService: ${message}`);
    }
}
BlueprintService.ɵfac = function BlueprintService_Factory(t) { return new (t || BlueprintService)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"]), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵinject"](_message_service__WEBPACK_IMPORTED_MODULE_5__["MessageService"])); };
BlueprintService.ɵprov = _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineInjectable"]({ token: BlueprintService, factory: BlueprintService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ "5f2+":
/*!******************************************************!*\
  !*** ./src/app/_components/login/login.component.ts ***!
  \******************************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/forms */ "3Pt+");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../_services */ "J9tS");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "ofXK");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "tyNb");






function LoginComponent_div_7_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Username is required");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function LoginComponent_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 10);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, LoginComponent_div_7_div_1_Template, 2, 0, "div", 11);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r0.formFields.username.errors.required);
} }
function LoginComponent_div_12_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Password is required");
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} }
function LoginComponent_div_12_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 10);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, LoginComponent_div_12_div_1_Template, 2, 0, "div", 11);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r1 = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx_r1.formFields.password.errors.required);
} }
function LoginComponent_span_15_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](0, "span", 12);
} }
const _c0 = function (a0) { return { "is-invalid": a0 }; };
class LoginComponent {
    constructor(formBuilder, authenticationService) {
        this.formBuilder = formBuilder;
        this.authenticationService = authenticationService;
        this.submitted = false;
        this.loading = false;
    }
    get formFields() {
        return this.loginForm.controls;
    }
    ngOnInit() {
        this.loginForm = this.formBuilder.group({
            username: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].required],
            password: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_0__["Validators"].required]
        });
    }
    onSubmit() {
        this.submitted = true;
        if (this.loginForm.invalid)
            return;
        this.loading = true;
        this.authenticationService.login(this.formFields.username.value, this.formFields.password.value);
        console.log("login submitted");
    }
}
LoginComponent.ɵfac = function LoginComponent_Factory(t) { return new (t || LoginComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_angular_forms__WEBPACK_IMPORTED_MODULE_0__["FormBuilder"]), _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_2__["AuthenticationService"])); };
LoginComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: LoginComponent, selectors: [["app-login"]], decls: 19, vars: 11, consts: [[3, "formGroup", "ngSubmit"], [1, "form-group"], ["for", "username"], ["type", "text", "formControlName", "username", 1, "form-control", 3, "ngClass"], ["class", "invalid-feedback", 4, "ngIf"], ["for", "password"], ["type", "password", "formControlName", "password", 1, "form-control", 3, "ngClass"], [1, "btn", "btn-primary", 3, "disabled"], ["class", "spinner-border spinner-border-sm mr-1", 4, "ngIf"], ["routerLink", "/register", 1, "btn", "btn-link"], [1, "invalid-feedback"], [4, "ngIf"], [1, "spinner-border", "spinner-border-sm", "mr-1"]], template: function LoginComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "h2");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](1, "Login");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "form", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("ngSubmit", function LoginComponent_Template_form_ngSubmit_2_listener() { return ctx.onSubmit(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](3, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "label", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](5, "Username");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](6, "input", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](7, LoginComponent_div_7_Template, 2, 1, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](9, "label", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](10, "Password");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](11, "input", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](12, LoginComponent_div_12_Template, 2, 1, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](13, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "button", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](15, LoginComponent_span_15_Template, 1, 0, "span", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](16, " Login ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](17, "a", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](18, "Register");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("formGroup", ctx.loginForm);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](7, _c0, ctx.submitted && ctx.formFields.username.errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.submitted && ctx.formFields.username.errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](9, _c0, ctx.submitted && ctx.formFields.password.errors));
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.submitted && ctx.formFields.password.errors);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("disabled", ctx.loading);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.loading);
    } }, directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_0__["ɵangular_packages_forms_forms_ba"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["NgControlStatusGroup"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["FormGroupDirective"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["DefaultValueAccessor"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["NgControlStatus"], _angular_forms__WEBPACK_IMPORTED_MODULE_0__["FormControlName"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgClass"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgIf"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterLinkWithHref"]], styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJsb2dpbi5jb21wb25lbnQuc2NzcyJ9 */"] });


/***/ }),

/***/ "5iIw":
/*!********************************************!*\
  !*** ./src/app/_components/login/index.ts ***!
  \********************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _login_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./login.component */ "5f2+");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return _login_component__WEBPACK_IMPORTED_MODULE_0__["LoginComponent"]; });




/***/ }),

/***/ "6xHr":
/*!*****************************************************************************************!*\
  !*** ./src/app/_components/collectibles/collectible-sort/collectible-sort.component.ts ***!
  \*****************************************************************************************/
/*! exports provided: CollectibleSortComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectibleSortComponent", function() { return CollectibleSortComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "ofXK");


function CollectibleSortComponent_div_4_Template(rf, ctx) { if (rf & 1) {
    const _r3 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "div", 4);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function CollectibleSortComponent_div_4_Template_div_click_1_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵrestoreView"](_r3); const method_r1 = ctx.$implicit; const ctx_r2 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"](); return ctx_r2.setSortingMethod(method_r1.value); });
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "div", 5);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](3, "input", 6);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const method_r1 = ctx.$implicit;
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("checked", ctx_r0.getSortingValue(method_r1.value));
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"](" ", method_r1.value, " ");
} }
class CollectibleSortComponent {
    constructor() {
        this.sortingMethods = {
            nameAscending: "Name ascending",
            nameDescending: "Name descending",
            categoryAscending: "Category ascending",
            categoryDescending: "Category descending"
        };
        this._sortingMethod = this.sortingMethods.nameAscending;
    }
    ngOnInit() {
        this.setSortingMethod(this._sortingMethod);
    }
    setSortingMethod(method) {
        if (this.sorter === undefined)
            return;
        this._sortingMethod = method;
        switch (method) {
            case this.sortingMethods.nameAscending:
                this.sorter.sortingMethod = this.sortByNameAscending;
                break;
            case this.sortingMethods.nameDescending:
                this.sorter.sortingMethod = this.sortByNameDescending;
                break;
            case this.sortingMethods.categoryDescending:
                this.sorter.sortingMethod = this.sortByCategoryDescending;
                break;
            default:
                this.sorter.sortingMethod = this.sortByCategoryAscending;
                break;
        }
        ;
    }
    getSortingValue(method) {
        return this._sortingMethod === method;
    }
    sortByNameAscending(collectibles) {
        collectibles.sort((collectibleA, collectibleB) => {
            const nameA = collectibleA.name;
            const nameB = collectibleB.name;
            return nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
        });
    }
    sortByNameDescending(collectibles) {
        collectibles.sort((collectibleA, collectibleB) => {
            const nameA = collectibleA.name;
            const nameB = collectibleB.name;
            return nameA > nameB ? -1 : nameA < nameB ? 1 : 0;
        });
    }
    sortByCategoryAscending(collectibles) {
        const charsOnlyUpperCase = this.charsOnlyUpperCase;
        collectibles.sort((collectibleA, collectibleB) => {
            const categoryA = charsOnlyUpperCase(collectibleA.category);
            const categoryB = charsOnlyUpperCase(collectibleB.category);
            const nameA = collectibleA.name;
            const nameB = collectibleB.name;
            return categoryA < categoryB ? -1 : categoryA > categoryB ? 1 :
                nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
        });
    }
    sortByCategoryDescending(collectibles) {
        const charsOnlyUpperCase = this.charsOnlyUpperCase;
        collectibles.sort((collectibleA, collectibleB) => {
            const categoryA = charsOnlyUpperCase(collectibleA.category);
            const categoryB = charsOnlyUpperCase(collectibleB.category);
            const nameA = collectibleA.name;
            const nameB = collectibleB.name;
            return categoryA > categoryB ? -1 : categoryA < categoryB ? 1 :
                nameA < nameB ? -1 : nameA > nameB ? 1 : 0;
        });
    }
    charsOnlyUpperCase(value) {
        const nonAlphaNumeric = /\W/;
        let match = value.toUpperCase().replace(nonAlphaNumeric, '');
        return match === null ? "" : match;
    }
}
CollectibleSortComponent.ɵfac = function CollectibleSortComponent_Factory(t) { return new (t || CollectibleSortComponent)(); };
CollectibleSortComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: CollectibleSortComponent, selectors: [["app-collectible-sort"]], inputs: { sorter: "sorter" }, decls: 6, vars: 3, consts: [[1, "container"], [1, "row"], ["class", "col-12 col-sm-6 col-lg-12", 4, "ngFor", "ngForOf"], [1, "col-12", "col-sm-6", "col-lg-12"], [1, "btn", "btn-primary", "category-toggle-container", 3, "click"], [1, "category-toggle", "nopointer"], ["type", "radio", 3, "checked"]], template: function CollectibleSortComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "h5");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3, "Sort by...");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](4, CollectibleSortComponent_div_4_Template, 5, 2, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpipe"](5, "keyvalue");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpipeBind1"](5, 1, ctx.sortingMethods));
    } }, directives: [_angular_common__WEBPACK_IMPORTED_MODULE_1__["NgForOf"]], pipes: [_angular_common__WEBPACK_IMPORTED_MODULE_1__["KeyValuePipe"]], styles: [".category-toggle-container[_ngcontent-%COMP%] {\n  position: relative;\n  height: 2em;\n  cursor: pointer;\n  margin: 3px 0px 3px;\n  width: 100%;\n  transition: 0s;\n}\n\n.category-toggle[_ngcontent-%COMP%] {\n  position: absolute;\n  left: 10px;\n  top: 50%;\n  transform: translateY(-50%);\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFwuLlxcY29sbGVjdGlibGUtc29ydC5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNHLGtCQUFBO0VBQ0EsV0FBQTtFQUNBLGVBQUE7RUFDQSxtQkFBQTtFQUNBLFdBQUE7RUFDQSxjQUFBO0FBQ0g7O0FBRUE7RUFDRyxrQkFBQTtFQUNBLFVBQUE7RUFDQSxRQUFBO0VBQ0EsMkJBQUE7QUFDSCIsImZpbGUiOiJjb2xsZWN0aWJsZS1zb3J0LmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmNhdGVnb3J5LXRvZ2dsZS1jb250YWluZXIge1xyXG4gICBwb3NpdGlvbjogcmVsYXRpdmU7XHJcbiAgIGhlaWdodDogMmVtO1xyXG4gICBjdXJzb3I6cG9pbnRlcjtcclxuICAgbWFyZ2luOiAzcHggMHB4IDNweDtcclxuICAgd2lkdGg6IDEwMCU7XHJcbiAgIHRyYW5zaXRpb246IDBzO1xyXG59XHJcblxyXG4uY2F0ZWdvcnktdG9nZ2xlIHtcclxuICAgcG9zaXRpb246IGFic29sdXRlO1xyXG4gICBsZWZ0OiAxMHB4O1xyXG4gICB0b3A6NTAlO1xyXG4gICB0cmFuc2Zvcm06IHRyYW5zbGF0ZVkoLTUwJSk7XHJcbn0iXX0= */"] });


/***/ }),

/***/ "8QbD":
/*!********************************************************************!*\
  !*** ./src/app/_components/collectibles/collectibles.component.ts ***!
  \********************************************************************/
/*! exports provided: CollectiblesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectiblesComponent", function() { return CollectiblesComponent; });
/* harmony import */ var _interfaces__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../_interfaces */ "rGDM");
/* harmony import */ var _collectibleFilter__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./collectibleFilter */ "YxNW");
/* harmony import */ var _collectibleSorter__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./collectibleSorter */ "g89b");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../_services */ "J9tS");
/* harmony import */ var _collectible_filter_collectible_filter_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./collectible-filter/collectible-filter.component */ "1lYs");
/* harmony import */ var _collectible_sort_collectible_sort_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./collectible-sort/collectible-sort.component */ "6xHr");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/common */ "ofXK");
/* harmony import */ var _collectible_card_collectible_card_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./collectible-card/collectible-card.component */ "p+Vk");









function CollectiblesComponent_div_8_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](1, "app-collectible-card", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
} if (rf & 2) {
    const collectible_r1 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("collectible", collectible_r1);
} }
class CollectiblesComponent {
    constructor(collectibleService) {
        this.collectibleService = collectibleService;
        this.collectibleFilter = new _collectibleFilter__WEBPACK_IMPORTED_MODULE_1__["CollectibleFilter"]();
        this.sorter = new _collectibleSorter__WEBPACK_IMPORTED_MODULE_2__["CollectibleSorter"]();
        this.collectibles = [];
    }
    get displayedCollectibles() {
        let result = [];
        for (let n = 0; n < this.collectibles.length; n++) {
            const collectible = this.collectibles[n];
            if (!this.collectibleFilter.shouldShowCollectible(collectible))
                continue;
            result.push(collectible);
        }
        this.sorter.sort(result);
        return result;
    }
    ngOnInit() {
        this.getCollectibles();
    }
    collectedValue(collectible) {
        return !collectible.obtained ? "Not obtained" :
            collectible.mastered ? "Mastered" : "Obtained";
    }
    collectedColor(collectible) {
        return !collectible.obtained ? "bg-dark" :
            collectible.mastered ? "bg-success" : "bg-light";
    }
    collectibleIcon(collectible) {
        switch (collectible.category) {
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Warframe: return "fas fa-meh-blank";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].PrimaryWeapon: return "fas fa-sun";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].SecondaryWeapon: return "fas fa-moon";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].MeleeWeapon: return "fas fa-sign-language";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Amp: return "fas fa-disease";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Pet: return "fas fa-dog";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].RoboGun: return "fas fa-cog";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Archwing: return "fa fa-fighter-jet";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].ArchGun: return "fas fa-dragon";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].ArchMelee: return "fas fa-cut";
            default: return "fa fa-question";
        }
    }
    getCollectibles() {
        this.collectibleService.getCollectibles()
            .subscribe(collectibles => this.collectibles = collectibles);
    }
}
CollectiblesComponent.ɵfac = function CollectiblesComponent_Factory(t) { return new (t || CollectiblesComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_4__["CollectibleService"])); };
CollectiblesComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineComponent"]({ type: CollectiblesComponent, selectors: [["app-collectible"]], decls: 9, vars: 3, consts: [[1, "d-flex", "flex-column", "flex-lg-row"], [1, "col-left", "sticky-column"], [3, "filter"], [3, "sorter"], [1, "col-mid"], [1, "card-container"], ["class", "col-12  col-md-6 col-lg-4 col-xl-3 p-0", 4, "ngFor", "ngForOf"], [1, "col-12", "col-md-6", "col-lg-4", "col-xl-3", "p-0"], [3, "collectible"]], template: function CollectiblesComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](1, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](2, "app-collectible-filter", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](3, "app-collectible-sort", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](4, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](5, "h2");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtext"](6, "Collectibles");
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementStart"](7, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵtemplate"](8, CollectiblesComponent_div_8_Template, 2, 1, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("filter", ctx.collectibleFilter);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("sorter", ctx.sorter);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵproperty"]("ngForOf", ctx.displayedCollectibles);
    } }, directives: [_collectible_filter_collectible_filter_component__WEBPACK_IMPORTED_MODULE_5__["CollectibleFilterComponent"], _collectible_sort_collectible_sort_component__WEBPACK_IMPORTED_MODULE_6__["CollectibleSortComponent"], _angular_common__WEBPACK_IMPORTED_MODULE_7__["NgForOf"], _collectible_card_collectible_card_component__WEBPACK_IMPORTED_MODULE_8__["CollectibleCardComponent"]], styles: [".position-icon[_ngcontent-%COMP%] {\n  position: absolute;\n  top: 10px;\n  left: 10px;\n}\n\n.bg-frame-nonobtained[_ngcontent-%COMP%] {\n  color: darkgray;\n}\n\n.collectible-text[_ngcontent-%COMP%] {\n  font-size: 1.25em;\n  transform: translateY(25%);\n}\n\n.card-container[_ngcontent-%COMP%] {\n  display: flex;\n  flex-wrap: wrap;\n}\n\n@media only screen and (min-width: 1200px) {\n  .col-left[_ngcontent-%COMP%] {\n    width: 20%;\n  }\n\n  .col-mid[_ngcontent-%COMP%] {\n    width: 80%;\n  }\n\n  .sticky-column[_ngcontent-%COMP%] {\n    align-self: flex-start;\n    position: sticky;\n    top: 0px;\n    overflow-y: auto;\n    height: 100vh;\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFxjb2xsZWN0aWJsZXMuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRyxrQkFBQTtFQUNBLFNBQUE7RUFDQSxVQUFBO0FBQ0g7O0FBRUE7RUFDRyxlQUFBO0FBQ0g7O0FBRUE7RUFDRyxpQkFBQTtFQUNBLDBCQUFBO0FBQ0g7O0FBSUE7RUFDRyxhQUFBO0VBQ0EsZUFBQTtBQURIOztBQUlBO0VBQ0c7SUFDRyxVQUFBO0VBREo7O0VBSUM7SUFDRyxVQUFBO0VBREo7O0VBSUM7SUFDRyxzQkFBQTtJQUVBLGdCQUFBO0lBQ0EsUUFBQTtJQUNBLGdCQUFBO0lBQ0EsYUFBQTtFQURKO0FBQ0YiLCJmaWxlIjoiY29sbGVjdGlibGVzLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLnBvc2l0aW9uLWljb24ge1xyXG4gICBwb3NpdGlvbjogYWJzb2x1dGU7XHJcbiAgIHRvcDogMTBweDtcclxuICAgbGVmdDogMTBweDtcclxufVxyXG5cclxuLmJnLWZyYW1lLW5vbm9idGFpbmVkIHtcclxuICAgY29sb3I6IGRhcmtncmF5O1xyXG59XHJcblxyXG4uY29sbGVjdGlibGUtdGV4dCB7XHJcbiAgIGZvbnQtc2l6ZTogMS4yNWVtO1xyXG4gICB0cmFuc2Zvcm06IHRyYW5zbGF0ZVkoMjUlKTtcclxufVxyXG5cclxuXHJcblxyXG4uY2FyZC1jb250YWluZXIge1xyXG4gICBkaXNwbGF5OiBmbGV4O1xyXG4gICBmbGV4LXdyYXA6IHdyYXA7XHJcbn1cclxuXHJcbkBtZWRpYSBvbmx5IHNjcmVlbiBhbmQgKG1pbi13aWR0aDogMTIwMHB4KSB7XHJcbiAgIC5jb2wtbGVmdCB7XHJcbiAgICAgIHdpZHRoOiAyMCU7XHJcbiAgIH1cclxuICAgXHJcbiAgIC5jb2wtbWlkIHtcclxuICAgICAgd2lkdGg6IDgwJTtcclxuICAgfVxyXG5cclxuICAgLnN0aWNreS1jb2x1bW4ge1xyXG4gICAgICBhbGlnbi1zZWxmOiBmbGV4LXN0YXJ0O1xyXG4gICAgICBwb3NpdGlvbjogLXdlYmtpdC1zdGlja3k7XHJcbiAgICAgIHBvc2l0aW9uOiBzdGlja3k7XHJcbiAgICAgIHRvcDowcHg7XHJcbiAgICAgIG92ZXJmbG93LXk6IGF1dG87XHJcbiAgICAgIGhlaWdodDogMTAwdmg7XHJcbiAgIH1cclxufSJdfQ== */"] });


/***/ }),

/***/ "AytR":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
const environment = {
    production: false,
    apiUrl: 'http://192.168.1.5:80'
    // apiUrl: 'http://localhost:12129'
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "J9tS":
/*!************************************!*\
  !*** ./src/app/_services/index.ts ***!
  \************************************/
/*! exports provided: AuthenticationService, BlueprintService, CollectibleService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _authentication_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./authentication.service */ "pW6c");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "AuthenticationService", function() { return _authentication_service__WEBPACK_IMPORTED_MODULE_0__["AuthenticationService"]; });

/* harmony import */ var _blueprint_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./blueprint.service */ "4FHd");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "BlueprintService", function() { return _blueprint_service__WEBPACK_IMPORTED_MODULE_1__["BlueprintService"]; });

/* harmony import */ var _collectible_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./collectible.service */ "j1ac");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "CollectibleService", function() { return _collectible_service__WEBPACK_IMPORTED_MODULE_2__["CollectibleService"]; });






/***/ }),

/***/ "Ndrk":
/*!**************************************!*\
  !*** ./src/app/_components/index.ts ***!
  \**************************************/
/*! exports provided: CollectibleCardComponent, CollectiblesComponent, WishListComponent, DetailsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _collectibles_collectible_card_collectible_card_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./collectibles/collectible-card/collectible-card.component */ "p+Vk");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "CollectibleCardComponent", function() { return _collectibles_collectible_card_collectible_card_component__WEBPACK_IMPORTED_MODULE_0__["CollectibleCardComponent"]; });

/* harmony import */ var _collectibles_collectibles_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./collectibles/collectibles.component */ "8QbD");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "CollectiblesComponent", function() { return _collectibles_collectibles_component__WEBPACK_IMPORTED_MODULE_1__["CollectiblesComponent"]; });

/* harmony import */ var _wish_list_wish_list_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./wish-list/wish-list.component */ "qwLP");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "WishListComponent", function() { return _wish_list_wish_list_component__WEBPACK_IMPORTED_MODULE_2__["WishListComponent"]; });

/* harmony import */ var _details_details_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./details/details.component */ "zIHm");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "DetailsComponent", function() { return _details_details_component__WEBPACK_IMPORTED_MODULE_3__["DetailsComponent"]; });







/***/ }),

/***/ "OdHV":
/*!************************************!*\
  !*** ./src/app/message.service.ts ***!
  \************************************/
/*! exports provided: MessageService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageService", function() { return MessageService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");

class MessageService {
    constructor() {
        this.messages = [];
    }
    add(message) {
        this.messages.push(message);
    }
    clear() {
        this.messages = [];
    }
}
MessageService.ɵfac = function MessageService_Factory(t) { return new (t || MessageService)(); };
MessageService.ɵprov = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjectable"]({ token: MessageService, factory: MessageService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ "SPnD":
/*!******************************************************!*\
  !*** ./src/app/_interfaces/collectibleCategories.ts ***!
  \******************************************************/
/*! exports provided: collectibleCategories, collectibleCategoryKeys */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "collectibleCategories", function() { return collectibleCategories; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "collectibleCategoryKeys", function() { return collectibleCategoryKeys; });
const collectibleCategories = {
    Warframe: "Warframe",
    PrimaryWeapon: "Primary Weapon",
    SecondaryWeapon: "Secondary Weapon",
    MeleeWeapon: "Melee Weapon",
    Amp: "Amp Prism",
    Pet: "Pet",
    RoboGun: "Robo-Gun",
    Archwing: "Archwing",
    ArchGun: "Archgun",
    ArchMelee: "Arch-Melee"
};
const collectibleCategoryKeys = {
    Warframe: "Warframe",
    PrimaryWeapon: "PrimaryWeapon",
    SecondaryWeapon: "SecondaryWeapon",
    MeleeWeapon: "MeleeWeapon",
    Amp: "Amp",
    Pet: "Pet",
    RoboGun: "RoboGun",
    Archwing: "Archwing",
    ArchGun: "ArchGun",
    ArchMelee: "ArchMelee"
};


/***/ }),

/***/ "Sy1n":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "tyNb");


class AppComponent {
    constructor() {
        this.title = 'Warframe Progress Tracker';
    }
}
AppComponent.ɵfac = function AppComponent_Factory(t) { return new (t || AppComponent)(); };
AppComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: AppComponent, selectors: [["app-root"]], decls: 12, vars: 1, consts: [[1, "container", "site-container"], [1, "row"], ["routerLink", "/collectibles", 1, "m-1"], ["routerLink", "/wishlist", 1, "m-1"], ["routerLink", "/login", 1, "m-1"]], template: function AppComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h1");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](4, "nav");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "a", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](6, "Collectibles");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "a", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](8, "Wishlist");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "a", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](10, "Login");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](11, "router-outlet");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](ctx.title);
    } }, directives: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterLinkWithHref"], _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterOutlet"]], styles: ["h1[_ngcontent-%COMP%] {\n  margin-bottom: 0;\n}\nnav[_ngcontent-%COMP%]   a[_ngcontent-%COMP%] {\n  padding: 1rem;\n  text-decoration: none;\n  margin-top: 10px;\n  display: inline-block;\n  background-color: #e8e8e8;\n  color: #3d3d3d;\n  border-radius: 4px;\n}\nnav[_ngcontent-%COMP%]   a[_ngcontent-%COMP%]:hover {\n  color: white;\n  background-color: #42545C;\n}\nnav[_ngcontent-%COMP%]   a.active[_ngcontent-%COMP%] {\n  background-color: black;\n}\n.site-container[_ngcontent-%COMP%] {\n  height: 100vh;\n}\n.btn[_ngcontent-%COMP%] {\n  transition-delay: 0s !important;\n  transition-duration: 0s !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcYXBwLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBLHNDQUFBO0FBQ0E7RUFDSSxnQkFBQTtBQUNKO0FBQ0E7RUFDRSxhQUFBO0VBQ0EscUJBQUE7RUFDQSxnQkFBQTtFQUNBLHFCQUFBO0VBQ0EseUJBQUE7RUFDQSxjQUFBO0VBQ0Esa0JBQUE7QUFFRjtBQUNBO0VBQ0UsWUFBQTtFQUNBLHlCQUFBO0FBRUY7QUFBQTtFQUNFLHVCQUFBO0FBR0Y7QUFBQTtFQUNFLGFBQUE7QUFHRjtBQURBO0VBQ0UsK0JBQUE7RUFDQSxrQ0FBQTtBQUlGIiwiZmlsZSI6ImFwcC5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi8qIEFwcENvbXBvbmVudCdzIHByaXZhdGUgQ1NTIHN0eWxlcyAqL1xyXG5oMSB7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAwO1xyXG59XHJcbm5hdiBhIHtcclxuICBwYWRkaW5nOiAxcmVtO1xyXG4gIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcclxuICBtYXJnaW4tdG9wOiAxMHB4O1xyXG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcclxuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZThlOGU4O1xyXG4gIGNvbG9yOiAjM2QzZDNkO1xyXG4gIGJvcmRlci1yYWRpdXM6IDRweDtcclxufVxyXG5cclxubmF2IGE6aG92ZXIge1xyXG4gIGNvbG9yOiB3aGl0ZTtcclxuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNDI1NDVDO1xyXG59XHJcbm5hdiBhLmFjdGl2ZSB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogYmxhY2s7XHJcbn1cclxuXHJcbi5zaXRlLWNvbnRhaW5lciB7XHJcbiAgaGVpZ2h0OiAxMDB2aDtcclxufVxyXG4uYnRuIHtcclxuICB0cmFuc2l0aW9uLWRlbGF5OiAwcyAhaW1wb3J0YW50O1xyXG4gIHRyYW5zaXRpb24tZHVyYXRpb246IDBzICFpbXBvcnRhbnQ7XHJcbn1cclxuICAiXX0= */"] });


/***/ }),

/***/ "T7zK":
/*!**********************************************************************************!*\
  !*** ./src/app/_components/wish-list/wish-list-card/wish-list-card.component.ts ***!
  \**********************************************************************************/
/*! exports provided: WishListCardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WishListCardComponent", function() { return WishListCardComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../_services */ "J9tS");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "tyNb");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "ofXK");




function WishListCardComponent_span_19_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "span", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const component_r2 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](component_r2.resultName);
} }
function WishListCardComponent_div_23_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "span", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const resource_r3 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate2"]("", resource_r3.name, ": ", resource_r3.amount, "");
} }
class WishListCardComponent {
    constructor(blueprintService, collectibleService) {
        this.blueprintService = blueprintService;
        this.collectibleService = collectibleService;
        this.mainBlueprint = { resultName: "", components: [] };
        this.componentBlueprints = [];
        this.resourceCosts = [];
    }
    ngOnInit() {
        this.loadBlueprints();
    }
    getComponentBlueprint(resultName) {
        let result = this.componentBlueprints.find(blueprint => blueprint.resultName === resultName);
        return result === undefined ? { resultName: "Null", components: [] } : result;
    }
    getBlueprintResourceCost(name) {
        let cost = this.resourceCosts.find(cost => cost.name === name);
        return cost === undefined ? { name: name, cost: [] } : cost;
    }
    get statusText() {
        return this.collectible.mastered ? "mastered" :
            this.collectible.obtained ? "obtained" : "not obtained";
    }
    increaseRank() {
        if (!this.collectible.obtained) {
            this.collectible.obtained = true;
        }
        else if (!this.collectible.mastered) {
            this.collectible.mastered = true;
        }
        else
            return;
        this.updateCollectible();
    }
    reduceRank() {
        if (this.collectible.mastered) {
            this.collectible.mastered = false;
        }
        else if (this.collectible.obtained) {
            this.collectible.obtained = false;
        }
        else
            return;
        this.updateCollectible();
    }
    removeFromWishlist() {
        console.log("Removing collectible", this.collectible.name, " from wishlist");
        this.collectible.onWishlist = false;
        this.updateCollectible();
        if (this.onDelete !== undefined)
            this.onDelete(this.collectible.name);
    }
    updateCollectible() {
        this.collectibleService.updateCollectible(this.collectible)
            .subscribe(() => { });
    }
    loadBlueprints() {
        this.loadBlueprint(this.collectible.name, (blueprint) => {
            if (blueprint === null || blueprint === undefined)
                return;
            this.mainBlueprint = blueprint;
            this.loadCosts(this.mainBlueprint.resultName);
            blueprint.components.forEach((component) => {
                this.loadBlueprint(component.name, (componentBlueprint) => {
                    if (componentBlueprint === null || componentBlueprint === undefined)
                        return;
                    this.componentBlueprints.push(componentBlueprint);
                    this.loadCosts(componentBlueprint.resultName);
                });
            });
        });
    }
    loadBlueprint(resultName, onResult) {
        this.blueprintService.getBlueprintsWithResult(resultName)
            .subscribe(components => {
            let blueprint = {
                resultName: resultName,
                components: components.map(component => {
                    return {
                        name: component.componentName,
                        componentCount: component.componentCount
                    };
                })
            };
            onResult(blueprint);
        });
    }
    loadCosts(resultName) {
        this.blueprintService.getTotalResourceCost(resultName)
            .subscribe(costs => {
            let blueprintCost = {
                name: resultName,
                cost: costs.map(stack => {
                    return {
                        id: stack.id,
                        name: stack.name,
                        amount: stack.amount
                    };
                })
            };
            this.resourceCosts.push(blueprintCost);
        });
    }
    getTotalCost() {
        let result = [];
        for (let n = 0; n < this.resourceCosts.length; n++) {
            for (let i = 0; i < this.resourceCosts[n].cost.length; i++) {
                let stack = this.resourceCosts[n].cost[i];
                let existingStack = result.findIndex(s => s.name === stack.name);
                if (existingStack > -1) {
                    result[existingStack].amount += stack.amount;
                }
                else {
                    result.push({ id: stack.id, name: stack.name, amount: stack.amount });
                }
            }
        }
        let creditsIndex = result.findIndex(stack => stack.name === "Credits");
        if (creditsIndex > -1) {
            let credits = result[creditsIndex];
            result.splice(creditsIndex, 1);
            result.splice(0, 0, credits);
        }
        return result;
    }
}
WishListCardComponent.ɵfac = function WishListCardComponent_Factory(t) { return new (t || WishListCardComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_1__["BlueprintService"]), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_1__["CollectibleService"])); };
WishListCardComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: WishListCardComponent, selectors: [["app-wish-list-card"]], inputs: { collectible: "collectible", onDelete: "onDelete" }, decls: 24, vars: 6, consts: [[1, "d-flex", "horizontal-list"], [3, "routerLink"], [1, "title-section", "btn", "btn-primary"], [1, "status-section", "d-flex"], [1, "status-section-buttons"], [1, "status-section-button", "btn", "btn-secondary", 3, "click"], [1, "remove-button", "btn", "btn-danger", 3, "click"], ["class", "component-card", 4, "ngFor", "ngForOf"], [1, "component-card"], [1, "card"]], template: function WishListCardComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "a", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "h4", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](4, "span", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "h5");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "button", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function WishListCardComponent_Template_button_click_8_listener() { return ctx.reduceRank(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](10, "-");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "button", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function WishListCardComponent_Template_button_click_11_listener() { return ctx.increaseRank(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](12, "span");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](13, "+");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](14, "button", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function WishListCardComponent_Template_button_click_14_listener() { return ctx.removeFromWishlist(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](15, "X");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](16, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "h5");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](18, "Components:");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](19, WishListCardComponent_span_19_Template, 3, 1, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](20, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](21, "h5");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](22, "Construction cost:");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](23, WishListCardComponent_div_23_Template, 3, 2, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵpropertyInterpolate2"]("routerLink", "/collectible/", ctx.collectible.category, "/", ctx.collectible.name, "");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](ctx.collectible.name);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"]("Status:", ctx.statusText, "");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](13);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx.componentBlueprints);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx.getTotalCost());
    } }, directives: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterLinkWithHref"], _angular_common__WEBPACK_IMPORTED_MODULE_3__["NgForOf"]], styles: [".component-card[_ngcontent-%COMP%] {\n  padding: 0 5px 0 5px;\n}\n\n.horizontal-list[_ngcontent-%COMP%] {\n  margin: 10px 0 10px;\n}\n\n.title-section[_ngcontent-%COMP%] {\n  width: 10em;\n}\n\n.status-section[_ngcontent-%COMP%] {\n  position: relative;\n  display: inline-block;\n  width: 15em;\n  margin-left: 3em;\n  margin-right: 3em;\n}\n\n.status-section-buttons[_ngcontent-%COMP%] {\n  position: absolute;\n  top: 0;\n  right: 0;\n  height: 100%;\n}\n\n.status-section-button[_ngcontent-%COMP%] {\n  position: relative;\n  height: 90%;\n  width: 25px;\n  margin-left: 5px;\n}\n\n.status-section-button[_ngcontent-%COMP%]   *[_ngcontent-%COMP%] {\n  font-size: 1.5em;\n  position: absolute;\n  top: 50%;\n  left: 50%;\n  transform: translate(-50%, -50%);\n}\n\n.remove-button[_ngcontent-%COMP%] {\n  position: absolute;\n  right: 5px;\n  top: 5px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFwuLlxcd2lzaC1saXN0LWNhcmQuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRyxvQkFBQTtBQUNIOztBQUVBO0VBQ0csbUJBQUE7QUFDSDs7QUFFQTtFQUNHLFdBQUE7QUFDSDs7QUFFQTtFQUNHLGtCQUFBO0VBQ0EscUJBQUE7RUFDQSxXQUFBO0VBQ0EsZ0JBQUE7RUFDQSxpQkFBQTtBQUNIOztBQUVBO0VBQ0csa0JBQUE7RUFDQSxNQUFBO0VBQ0EsUUFBQTtFQUNBLFlBQUE7QUFDSDs7QUFFQTtFQUNHLGtCQUFBO0VBQ0EsV0FBQTtFQUNBLFdBQUE7RUFDQSxnQkFBQTtBQUNIOztBQUlBO0VBQ0csZ0JBQUE7RUFDQSxrQkFBQTtFQUNBLFFBQUE7RUFDQSxTQUFBO0VBQ0EsZ0NBQUE7QUFESDs7QUFJQTtFQUNHLGtCQUFBO0VBQ0EsVUFBQTtFQUNBLFFBQUE7QUFESCIsImZpbGUiOiJ3aXNoLWxpc3QtY2FyZC5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi5jb21wb25lbnQtY2FyZCB7XHJcbiAgIHBhZGRpbmc6IDAgNXB4IDAgNXB4O1xyXG59XHJcblxyXG4uaG9yaXpvbnRhbC1saXN0IHtcclxuICAgbWFyZ2luOiAxMHB4IDAgMTBweDtcclxufVxyXG5cclxuLnRpdGxlLXNlY3Rpb24ge1xyXG4gICB3aWR0aDogMTBlbTtcclxufVxyXG5cclxuLnN0YXR1cy1zZWN0aW9uIHtcclxuICAgcG9zaXRpb246cmVsYXRpdmU7XHJcbiAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcclxuICAgd2lkdGg6IDE1ZW07XHJcbiAgIG1hcmdpbi1sZWZ0OiAzZW07XHJcbiAgIG1hcmdpbi1yaWdodDogM2VtO1xyXG59XHJcblxyXG4uc3RhdHVzLXNlY3Rpb24tYnV0dG9ucyB7XHJcbiAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcclxuICAgdG9wOiAwO1xyXG4gICByaWdodDogMDtcclxuICAgaGVpZ2h0OiAxMDAlO1xyXG59XHJcblxyXG4uc3RhdHVzLXNlY3Rpb24tYnV0dG9uIHtcclxuICAgcG9zaXRpb246IHJlbGF0aXZlO1xyXG4gICBoZWlnaHQ6IDkwJTtcclxuICAgd2lkdGg6IDI1cHg7XHJcbiAgIG1hcmdpbi1sZWZ0OiA1cHg7XHJcbn1cclxuXHJcblxyXG5cclxuLnN0YXR1cy1zZWN0aW9uLWJ1dHRvbiAqIHtcclxuICAgZm9udC1zaXplOiAxLjVlbTtcclxuICAgcG9zaXRpb246IGFic29sdXRlO1xyXG4gICB0b3A6NTAlO1xyXG4gICBsZWZ0OjUwJTtcclxuICAgdHJhbnNmb3JtOnRyYW5zbGF0ZSgtNTAlLCAtNTAlKTtcclxufVxyXG5cclxuLnJlbW92ZS1idXR0b24ge1xyXG4gICBwb3NpdGlvbjogYWJzb2x1dGU7XHJcbiAgIHJpZ2h0OiA1cHg7XHJcbiAgIHRvcDogNXB4O1xyXG59Il19 */"] });


/***/ }),

/***/ "YxNW":
/*!***************************************************************!*\
  !*** ./src/app/_components/collectibles/collectibleFilter.ts ***!
  \***************************************************************/
/*! exports provided: CollectibleFilter */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectibleFilter", function() { return CollectibleFilter; });
/* harmony import */ var _interfaces__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../_interfaces */ "rGDM");

class CollectibleFilter {
    constructor() {
        this._filter = {
            filterText: "", allowedObtainedState: _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].NotObtained, includedCategories: {}
        };
    }
    set filter(filter) { this._filter = filter; }
    shouldShowCollectible(collectible) {
        const filter = this._filter;
        return this.shouldShowCategory(collectible.category, filter.includedCategories)
            && this.passesObtainedFilter(collectible, filter.allowedObtainedState)
            && this.containsString(collectible, filter.filterText);
    }
    shouldShowCategory(category, shownCategories) {
        return shownCategories[category];
    }
    passesObtainedFilter(collectible, allowedState) {
        return allowedState === _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].Any ||
            collectible.obtained && !collectible.mastered && allowedState === _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].Obtained ||
            !collectible.obtained && allowedState === _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].NotObtained ||
            collectible.mastered && allowedState === _interfaces__WEBPACK_IMPORTED_MODULE_0__["obtainedState"].Mastered;
    }
    containsString(collectible, value) {
        value = value.trim();
        if (value.length == 0)
            return true;
        let collectibleName = collectible.name.toLowerCase();
        let collectibleCategory = collectible.category.toLowerCase();
        let filter = value.toLowerCase().trim();
        const regularExpression = /,/;
        let targetValues = filter.split(regularExpression);
        for (let n = 0; n < targetValues.length; n++) {
            targetValues[n] = targetValues[n].trim();
            let mustIncludes = targetValues[n].split(' ');
            let containsAll = true;
            for (let i = 0; i < mustIncludes.length; i++) {
                if (!collectibleName.includes(mustIncludes[i])
                    && !collectibleCategory.includes(mustIncludes[i])) {
                    containsAll = false;
                    break;
                }
            }
            if (containsAll)
                return true;
        }
        return false;
    }
}


/***/ }),

/***/ "ZAI4":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser */ "jhN1");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ "3Pt+");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "tk/3");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app-routing.module */ "vY5A");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app.component */ "Sy1n");
/* harmony import */ var _components_messages_messages_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./_components/messages/messages.component */ "bECa");
/* harmony import */ var _components_login_login_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./_components/login/login.component */ "5f2+");
/* harmony import */ var _register_register_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./register/register.component */ "1W4x");
/* harmony import */ var _components__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./_components */ "Ndrk");
/* harmony import */ var _components_collectibles_collectible_card_collectible_card_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./_components/collectibles/collectible-card/collectible-card.component */ "p+Vk");
/* harmony import */ var _components_wish_list_wish_list_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./_components/wish-list/wish-list.component */ "qwLP");
/* harmony import */ var _components_wish_list_item_cost_card_item_cost_card_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./_components/wish-list/item-cost-card/item-cost-card.component */ "1s4E");
/* harmony import */ var _components_details_details_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./_components/details/details.component */ "zIHm");
/* harmony import */ var _components_collectibles_collectible_filter_collectible_filter_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./_components/collectibles/collectible-filter/collectible-filter.component */ "1lYs");
/* harmony import */ var _components_collectibles_collectible_sort_collectible_sort_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./_components/collectibles/collectible-sort/collectible-sort.component */ "6xHr");
/* harmony import */ var _components_wish_list_wish_list_card_wish_list_card_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./_components/wish-list/wish-list-card/wish-list-card.component */ "T7zK");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/core */ "fXoL");


















class AppModule {
}
AppModule.ɵfac = function AppModule_Factory(t) { return new (t || AppModule)(); };
AppModule.ɵmod = _angular_core__WEBPACK_IMPORTED_MODULE_16__["ɵɵdefineNgModule"]({ type: AppModule, bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"]] });
AppModule.ɵinj = _angular_core__WEBPACK_IMPORTED_MODULE_16__["ɵɵdefineInjector"]({ providers: [], imports: [[
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["BrowserModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_3__["AppRoutingModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormsModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_1__["ReactiveFormsModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClientModule"]
            // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
            // and returns simulated server responses.
            // Remove it when a real server is ready to receive requests.
            /*
            HttpClientInMemoryWebApiModule.forRoot(
               InMemoryDataService, { dataEncapsulation: false }
            )*/
        ]] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_16__["ɵɵsetNgModuleScope"](AppModule, { declarations: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"],
        _components_messages_messages_component__WEBPACK_IMPORTED_MODULE_5__["MessagesComponent"],
        _components_login_login_component__WEBPACK_IMPORTED_MODULE_6__["LoginComponent"],
        _register_register_component__WEBPACK_IMPORTED_MODULE_7__["RegisterComponent"],
        _components__WEBPACK_IMPORTED_MODULE_8__["CollectiblesComponent"],
        _components_collectibles_collectible_card_collectible_card_component__WEBPACK_IMPORTED_MODULE_9__["CollectibleCardComponent"],
        _components_wish_list_wish_list_component__WEBPACK_IMPORTED_MODULE_10__["WishListComponent"],
        _components_wish_list_item_cost_card_item_cost_card_component__WEBPACK_IMPORTED_MODULE_11__["ItemCostCardComponent"],
        _components_details_details_component__WEBPACK_IMPORTED_MODULE_12__["DetailsComponent"],
        _components_collectibles_collectible_filter_collectible_filter_component__WEBPACK_IMPORTED_MODULE_13__["CollectibleFilterComponent"],
        _components_collectibles_collectible_sort_collectible_sort_component__WEBPACK_IMPORTED_MODULE_14__["CollectibleSortComponent"],
        _components_wish_list_wish_list_card_wish_list_card_component__WEBPACK_IMPORTED_MODULE_15__["WishListCardComponent"]], imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["BrowserModule"],
        _app_routing_module__WEBPACK_IMPORTED_MODULE_3__["AppRoutingModule"],
        _angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormsModule"],
        _angular_forms__WEBPACK_IMPORTED_MODULE_1__["ReactiveFormsModule"],
        _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClientModule"]
        // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
        // and returns simulated server responses.
        // Remove it when a real server is ready to receive requests.
        /*
        HttpClientInMemoryWebApiModule.forRoot(
           InMemoryDataService, { dataEncapsulation: false }
        )*/
    ] }); })();


/***/ }),

/***/ "Zk0c":
/*!******************************************************!*\
  !*** ./src/app/_interfaces/collectibleSearchForm.ts ***!
  \******************************************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);



/***/ }),

/***/ "aGj9":
/*!******************************************!*\
  !*** ./src/app/_interfaces/blueprint.ts ***!
  \******************************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);



/***/ }),

/***/ "bECa":
/*!************************************************************!*\
  !*** ./src/app/_components/messages/messages.component.ts ***!
  \************************************************************/
/*! exports provided: MessagesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessagesComponent", function() { return MessagesComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../message.service */ "OdHV");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ofXK");



function MessagesComponent_div_4_div_1_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const message_r2 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"](" ", message_r2, " ");
} }
function MessagesComponent_div_4_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](1, MessagesComponent_div_4_div_1_Template, 2, 1, "div", 2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx_r0.messageService.messages);
} }
class MessagesComponent {
    constructor(messageService) {
        this.messageService = messageService;
    }
    ngOnInit() {
    }
}
MessagesComponent.ɵfac = function MessagesComponent_Factory(t) { return new (t || MessagesComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_message_service__WEBPACK_IMPORTED_MODULE_1__["MessageService"])); };
MessagesComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: MessagesComponent, selectors: [["app-messages"]], decls: 5, vars: 1, consts: [[1, "clear", 3, "click"], [4, "ngIf"], [4, "ngFor", "ngForOf"]], template: function MessagesComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "h2");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "Messages");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "button", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function MessagesComponent_Template_button_click_2_listener() { return ctx.messageService.clear(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3, "Clear messages");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](4, MessagesComponent_div_4_Template, 2, 1, "div", 1);
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngIf", ctx.messageService.messages.length);
    } }, directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["NgIf"], _angular_common__WEBPACK_IMPORTED_MODULE_2__["NgForOf"]], styles: ["h2[_ngcontent-%COMP%] {\n  color: #A80000;\n  font-family: Arial, Helvetica, sans-serif;\n  font-weight: lighter;\n}\n.clear[_ngcontent-%COMP%] {\n  color: #333;\n  background-color: #eee;\n  margin-bottom: 12px;\n  padding: 1rem;\n  border-radius: 4px;\n  font-size: 1rem;\n}\n.clear[_ngcontent-%COMP%]:hover {\n  color: white;\n  background-color: #42545C;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFxtZXNzYWdlcy5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQSwyQ0FBQTtBQUNBO0VBQ0ksY0FBQTtFQUNBLHlDQUFBO0VBQ0Esb0JBQUE7QUFDSjtBQUVFO0VBQ0UsV0FBQTtFQUNBLHNCQUFBO0VBQ0EsbUJBQUE7RUFDQSxhQUFBO0VBQ0Esa0JBQUE7RUFDQSxlQUFBO0FBQ0o7QUFDRTtFQUNFLFlBQUE7RUFDQSx5QkFBQTtBQUVKIiwiZmlsZSI6Im1lc3NhZ2VzLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLyogTWVzc2FnZXNDb21wb25lbnQncyBwcml2YXRlIENTUyBzdHlsZXMgKi9cclxuaDIge1xyXG4gICAgY29sb3I6ICNBODAwMDA7XHJcbiAgICBmb250LWZhbWlseTogQXJpYWwsIEhlbHZldGljYSwgc2Fucy1zZXJpZjtcclxuICAgIGZvbnQtd2VpZ2h0OiBsaWdodGVyO1xyXG4gIH1cclxuICBcclxuICAuY2xlYXIge1xyXG4gICAgY29sb3I6ICMzMzM7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjZWVlO1xyXG4gICAgbWFyZ2luLWJvdHRvbTogMTJweDtcclxuICAgIHBhZGRpbmc6IDFyZW07XHJcbiAgICBib3JkZXItcmFkaXVzOiA0cHg7XHJcbiAgICBmb250LXNpemU6IDFyZW07XHJcbiAgfVxyXG4gIC5jbGVhcjpob3ZlciB7XHJcbiAgICBjb2xvcjogd2hpdGU7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjNDI1NDVDO1xyXG4gIH0iXX0= */"] });


/***/ }),

/***/ "dRa/":
/*!********************************************!*\
  !*** ./src/app/_interfaces/collectible.ts ***!
  \********************************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
;



/***/ }),

/***/ "g89b":
/*!***************************************************************!*\
  !*** ./src/app/_components/collectibles/collectibleSorter.ts ***!
  \***************************************************************/
/*! exports provided: CollectibleSorter */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectibleSorter", function() { return CollectibleSorter; });
class CollectibleSorter {
    sort(collectibles) {
        if (this.sortingMethod === undefined)
            return;
        this.sortingMethod(collectibles);
    }
    charsOnlyUpperCase(value) {
        const nonAlphaNumeric = /\W/;
        let match = value.toUpperCase().replace(nonAlphaNumeric, '');
        return match === null ? "" : match;
    }
}


/***/ }),

/***/ "j1ac":
/*!**************************************************!*\
  !*** ./src/app/_services/collectible.service.ts ***!
  \**************************************************/
/*! exports provided: CollectibleService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectibleService", function() { return CollectibleService; });
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! rxjs */ "qCKp");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs/operators */ "kU1M");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../environments/environment */ "AytR");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "tk/3");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../message.service */ "OdHV");






class CollectibleService {
    constructor(http, messageService) {
        this.http = http;
        this.messageService = messageService;
        this.apiUrl = _environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].apiUrl;
        this.collectibleApiUrlGet = _environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].apiUrl + "/collectible/get";
        this.collectibleApiGetWithName = _environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].apiUrl + "/collectible/getwithname";
        this.collectibleApiSet = _environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].apiUrl + "/collectible/set";
        this._defaultSearchForm = {
            includeFrames: true,
            includePrimaryWeapons: true,
            includeSecondaryWeapons: true,
            includeMeleeWeapons: true,
            includePets: true,
            includeRoboWeapons: true,
            includeOperatorAmps: true,
            includeArchwings: true,
            includeArchGuns: true,
            includeArchMeleeWeapons: true,
            onlyOnWishlist: false,
            includeOwned: true,
            includeMastered: true,
            searchText: ""
        };
    }
    getCollectibles(searchForm = this._defaultSearchForm) {
        return this.http.put(this.collectibleApiUrlGet, searchForm, { withCredentials: true })
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_1__["catchError"])(this.handleError('getCollectibles,', [])));
    }
    getCollectible(category, name) {
        let info = { category: category, name: name };
        return this.http.put(this.collectibleApiGetWithName, info, { withCredentials: true });
    }
    updateCollectible(collectible) {
        return this.http.put(this.collectibleApiSet, collectible, { withCredentials: true })
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_1__["tap"])(() => this.log(`updated userCollectible:${collectible.name}`)), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_1__["catchError"])(this.handleError('upgradeCollectibleRank')));
    }
    addToWishlist(collectible) {
        throw "add to wish list not implemented";
    }
    removeFromWishlist(collectible) {
        throw "remove from wish list not implemented";
    }
    log(message) {
        this.messageService.add(`FrameService: ${message}`);
    }
    handleError(operation = 'operation', result) {
        return (error) => {
            console.error(error); // log to console instead
            this.log(`${operation} failed: ${error.message}`);
            return Object(rxjs__WEBPACK_IMPORTED_MODULE_0__["of"])(result);
        };
    }
}
CollectibleService.ɵfac = function CollectibleService_Factory(t) { return new (t || CollectibleService)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"]), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵinject"](_message_service__WEBPACK_IMPORTED_MODULE_5__["MessageService"])); };
CollectibleService.ɵprov = _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineInjectable"]({ token: CollectibleService, factory: CollectibleService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ "lZQ7":
/*!***********************************!*\
  !*** ./src/app/register/index.ts ***!
  \***********************************/
/*! exports provided: RegisterComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _register_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./register.component */ "1W4x");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "RegisterComponent", function() { return _register_component__WEBPACK_IMPORTED_MODULE_0__["RegisterComponent"]; });




/***/ }),

/***/ "p+Vk":
/*!*****************************************************************************************!*\
  !*** ./src/app/_components/collectibles/collectible-card/collectible-card.component.ts ***!
  \*****************************************************************************************/
/*! exports provided: CollectibleCardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CollectibleCardComponent", function() { return CollectibleCardComponent; });
/* harmony import */ var _interfaces__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../_interfaces */ "rGDM");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../_services */ "J9tS");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "tyNb");




class CollectibleCardComponent {
    constructor(collectibleService) {
        this.collectibleService = collectibleService;
    }
    ngOnInit() { }
    collectedColor(collectible) {
        return !collectible.obtained ? "bg-dark" :
            collectible.mastered ? "bg-warning" : "bg-light";
    }
    collectibleIcon(collectible) {
        switch (collectible.category) {
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Warframe: return "fas fa-meh-blank";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].PrimaryWeapon: return "fas fa-sun";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].SecondaryWeapon: return "fas fa-moon";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].MeleeWeapon: return "fas fa-sign-language";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Amp: return "fas fa-disease";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Pet: return "fas fa-dog";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].RoboGun: return "fas fa-cog";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].Archwing: return "fa fa-fighter-jet";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].ArchGun: return "fas fa-dragon";
            case _interfaces__WEBPACK_IMPORTED_MODULE_0__["collectibleCategories"].ArchMelee: return "fas fa-cut";
            default: return "fa fa-question";
        }
    }
    increaseRank() {
        if (!this.collectible.obtained) {
            this.collectible.obtained = true;
        }
        else if (!this.collectible.mastered) {
            this.collectible.mastered = true;
        }
        else
            return;
        this.updateCollectible();
    }
    reduceRank() {
        // console.log("Reducing rank for collectible", this.collectible.name);
    }
    addToWishlist() {
        this.collectible.onWishlist = true;
        this.updateCollectible();
    }
    removeFromWishlist() {
        this.collectible.onWishlist = false;
        this.updateCollectible();
    }
    toggleWishList() {
        if (this.collectible.onWishlist)
            this.removeFromWishlist();
        else
            this.addToWishlist();
    }
    getWishListStyle() {
        return this.collectible.onWishlist ? "status-icon" : "hide";
    }
    getRankIcon() {
        return this.collectible.mastered ? "fas fa-crown" :
            this.collectible.obtained ? "fas fa-check" : "hidden";
    }
    getRankStyle() {
        return this.collectible.obtained ? "status-icon" : "hide";
    }
    updateCollectible() {
        this.collectibleService.updateCollectible(this.collectible)
            .subscribe(() => { });
    }
}
CollectibleCardComponent.ɵfac = function CollectibleCardComponent_Factory(t) { return new (t || CollectibleCardComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_2__["CollectibleService"])); };
CollectibleCardComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: CollectibleCardComponent, selectors: [["app-collectible-card"]], inputs: { collectible: "collectible" }, decls: 22, vars: 16, consts: [[1, "card-body", "m-1", "p-0"], [1, "font-weight-bold", "text-light", "card-title", "noselect", "nopointer"], [1, "bg-secondary", "component-container"], [1, "card-part", "part-left", "btn", "btn-secondary"], [3, "routerLink"], [1, "fas", "fa-eye", "button-icon"], [1, "tooltip-text"], [1, "card-part", "part-center", "btn", "btn-secondary", 3, "click"], [1, "fa", "fa-bars", "button-icon"], [1, "card-part", "part-right", "btn", "btn-secondary", 3, "click"], [1, "fas", "fa-check", "button-icon"], [1, "tooltip-text", "text-dark"], [1, "status-icon-container", "m-0", "p-0", "nopointer"]], template: function CollectibleCardComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "p", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](5, "button", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](6, "a", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](7, "i", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](9, "Go to details page");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](10, "button", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("click", function CollectibleCardComponent_Template_button_click_10_listener() { return ctx.toggleWishList(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](11, "i", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](12, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](13, "Add to wishlist");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "button", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("click", function CollectibleCardComponent_Template_button_click_14_listener() { return ctx.increaseRank(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](15, "i", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](16, "span", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](17, "Increase rank");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](18, "i");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](19, "div", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](20, "i");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](21, "i");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵclassMapInterpolate1"]("m-1 card collectible-card ", ctx.collectedColor(ctx.collectible), "");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate"](ctx.collectible.name);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpropertyInterpolate2"]("routerLink", "/collectible/", ctx.collectible.category, "/", ctx.collectible.name, "");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵclassMapInterpolate1"]("", ctx.collectibleIcon(ctx.collectible), " category-icon noselect nopointer");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵclassMapInterpolate1"]("", ctx.getWishListStyle(), " fa fa-bars");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵclassMapInterpolate2"]("", ctx.getRankStyle(), " ", ctx.getRankIcon(), "");
    } }, directives: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterLinkWithHref"]], styles: [".card-part[_ngcontent-%COMP%] {\n  border-radius: 0;\n  padding: 0;\n}\n\n.hide[_ngcontent-%COMP%] {\n  display: none;\n}\n\n.status-icon[_ngcontent-%COMP%] {\n  animation-name: addIcon;\n  animation-duration: 0.35s;\n  animation-timing-function: ease;\n  color: whitesmoke;\n  font-size: 0.75em;\n  margin-left: 2px;\n  margin-right: 2px;\n}\n\n.status-icon-container[_ngcontent-%COMP%] {\n  top: 5px;\n  right: 10px;\n  text-align: right;\n  position: absolute;\n}\n\n@keyframes addIcon {\n  0% {\n    color: transparent;\n    font-size: 0em;\n  }\n  50% {\n    font-size: 1.25em;\n  }\n  100% {\n    color: whitesmoke;\n    font-size: 0.75em;\n  }\n}\n\n\n\n.component-container[_ngcontent-%COMP%] {\n  width: 100%;\n  border-radius: 0 0 5px 5px;\n  min-height: 4em;\n  display: flex;\n}\n\n.card-top-container[_ngcontent-%COMP%] {\n  display: none;\n  height: 0em;\n}\n\n.card-part[_ngcontent-%COMP%]:hover {\n  transition: 0s;\n}\n\n.card-part[_ngcontent-%COMP%]   i[_ngcontent-%COMP%] {\n  color: gray;\n  font-size: 2em;\n}\n\n.button-icon[_ngcontent-%COMP%] {\n  color: gray;\n  font-size: 2em;\n}\n\n.part-center[_ngcontent-%COMP%] {\n  width: 34.5%;\n  border-radius: 0;\n}\n\n.part-left[_ngcontent-%COMP%] {\n  border-radius: 0 0 0 5px;\n  width: 33%;\n}\n\n.part-right[_ngcontent-%COMP%] {\n  border-radius: 0 0 5px 0;\n  width: 33%;\n}\n\n.category-icon[_ngcontent-%COMP%] {\n  position: absolute;\n  top: 10px;\n  left: 10px;\n}\n\n.card-body[_ngcontent-%COMP%] {\n  border-radius: 5px;\n}\n\n.bg-frame-nonobtained[_ngcontent-%COMP%] {\n  color: darkgray;\n}\n\n.card-title[_ngcontent-%COMP%] {\n  position: absolute;\n  left: 50%;\n  top: 50%;\n  transform: translate(-50%, -50%);\n  font-size: 1.25em;\n  text-align: center;\n  vertical-align: center;\n}\n\n.tooltip-text[_ngcontent-%COMP%] {\n  visibility: hidden;\n  position: absolute;\n  width: 120px;\n  font-size: 0.5em;\n  font-weight: normal;\n  text-align: center;\n  border-radius: 2px;\n  padding: 5px 5px;\n  z-index: 1;\n  transform: translate(-77px, 40px);\n  background-color: whitesmoke;\n  border: solid 1px black;\n  box-shadow: 2px 2px 3px black;\n}\n\n@media only screen and (min-width: 992px) {\n  .card-part[_ngcontent-%COMP%]   i[_ngcontent-%COMP%] {\n    visibility: hidden;\n    color: #797979;\n  }\n\n  .card-part[_ngcontent-%COMP%]:hover   i[_ngcontent-%COMP%] {\n    visibility: visible;\n  }\n\n  .card-bottom-container[_ngcontent-%COMP%] {\n    display: flex;\n    min-height: 2em;\n  }\n\n  .card-top-container[_ngcontent-%COMP%] {\n    display: inline-block;\n    min-height: 4em;\n  }\n\n  \n  .card-title[_ngcontent-%COMP%] {\n    position: absolute;\n    left: 50%;\n    top: 50%;\n    transform: translate(-50%, -50%);\n    font-size: 1.25em;\n    width: 80%;\n    text-align: center;\n    vertical-align: center;\n  }\n\n  \n  .card-part[_ngcontent-%COMP%]:hover   .tooltip-text[_ngcontent-%COMP%] {\n    visibility: visible;\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFwuLlxcY29sbGVjdGlibGUtY2FyZC5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNHLGdCQUFBO0VBQ0EsVUFBQTtBQUNIOztBQUVBO0VBQ0csYUFBQTtBQUNIOztBQUVBO0VBQ0csdUJBQUE7RUFDQSx5QkFBQTtFQUNBLCtCQUFBO0VBQ0EsaUJBQUE7RUFDQSxpQkFBQTtFQUNBLGdCQUFBO0VBQ0EsaUJBQUE7QUFDSDs7QUFFQTtFQUNHLFFBQUE7RUFDQSxXQUFBO0VBQ0EsaUJBQUE7RUFDQSxrQkFBQTtBQUNIOztBQUVBO0VBQ0c7SUFBSyxrQkFBQTtJQUFtQixjQUFBO0VBR3pCO0VBRkE7SUFBTyxpQkFBQTtFQUtQO0VBSkE7SUFBTSxpQkFBQTtJQUFrQixpQkFBQTtFQVF4QjtBQUNGOztBQVBBOzs7OztJQUFBOztBQU9BO0VBQ0csV0FBQTtFQUNBLDBCQUFBO0VBQ0EsZUFBQTtFQUNBLGFBQUE7QUFRSDs7QUFMQTtFQUNHLGFBQUE7RUFDQSxXQUFBO0FBUUg7O0FBTEE7RUFDRyxjQUFBO0FBUUg7O0FBTEE7RUFDRyxXQUFBO0VBQ0EsY0FBQTtBQVFIOztBQUxBO0VBQ0csV0FBQTtFQUNBLGNBQUE7QUFRSDs7QUFMQTtFQUNHLFlBQUE7RUFDQSxnQkFBQTtBQVFIOztBQUxBO0VBQ0csd0JBQUE7RUFDQSxVQUFBO0FBUUg7O0FBTEE7RUFDRyx3QkFBQTtFQUNBLFVBQUE7QUFRSDs7QUFMQTtFQUNHLGtCQUFBO0VBQ0EsU0FBQTtFQUNBLFVBQUE7QUFRSDs7QUFMQTtFQUNHLGtCQUFBO0FBUUg7O0FBTEE7RUFDRyxlQUFBO0FBUUg7O0FBTEE7RUFDRyxrQkFBQTtFQUNBLFNBQUE7RUFDQSxRQUFBO0VBQ0EsZ0NBQUE7RUFDQSxpQkFBQTtFQUNBLGtCQUFBO0VBQ0Esc0JBQUE7QUFRSDs7QUFMQTtFQUNHLGtCQUFBO0VBQ0Esa0JBQUE7RUFDQSxZQUFBO0VBRUEsZ0JBQUE7RUFDQSxtQkFBQTtFQUNBLGtCQUFBO0VBQ0Esa0JBQUE7RUFDQSxnQkFBQTtFQUNBLFVBQUE7RUFDQSxpQ0FBQTtFQUNBLDRCQUFBO0VBQ0EsdUJBQUE7RUFDQSw2QkFBQTtBQU9IOztBQUpDO0VBQ0U7SUFDRyxrQkFBQTtJQUNBLGNBQUE7RUFPSjs7RUFMQztJQUNHLG1CQUFBO0VBUUo7O0VBTEM7SUFDRyxhQUFBO0lBQ0EsZUFBQTtFQVFKOztFQUxDO0lBQ0cscUJBQUE7SUFDQSxlQUFBO0VBUUo7O0VBTkYsR0FBQTtFQUVHO0lBQ0csa0JBQUE7SUFDQSxTQUFBO0lBQ0EsUUFBQTtJQUNBLGdDQUFBO0lBQ0EsaUJBQUE7SUFDQSxVQUFBO0lBQ0Esa0JBQUE7SUFDQSxzQkFBQTtFQVFKOztFQVBFLEdBQUE7RUFFQTtJQUNFLG1CQUFBO0VBU0o7QUFDRiIsImZpbGUiOiJjb2xsZWN0aWJsZS1jYXJkLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmNhcmQtcGFydCB7ICAgXHJcbiAgIGJvcmRlci1yYWRpdXM6IDA7XHJcbiAgIHBhZGRpbmc6IDA7XHJcbn1cclxuXHJcbi5oaWRlIHtcclxuICAgZGlzcGxheTogbm9uZTtcclxufVxyXG5cclxuLnN0YXR1cy1pY29uIHtcclxuICAgYW5pbWF0aW9uLW5hbWU6IGFkZEljb247XHJcbiAgIGFuaW1hdGlvbi1kdXJhdGlvbjogMC4zNXM7XHJcbiAgIGFuaW1hdGlvbi10aW1pbmctZnVuY3Rpb246IGVhc2U7XHJcbiAgIGNvbG9yOiB3aGl0ZXNtb2tlO1xyXG4gICBmb250LXNpemU6IDAuNzVlbTtcclxuICAgbWFyZ2luLWxlZnQ6IDJweDtcclxuICAgbWFyZ2luLXJpZ2h0OiAycHg7XHJcbn1cclxuXHJcbi5zdGF0dXMtaWNvbi1jb250YWluZXIge1xyXG4gICB0b3A6IDVweDtcclxuICAgcmlnaHQ6IDEwcHg7XHJcbiAgIHRleHQtYWxpZ246IHJpZ2h0O1xyXG4gICBwb3NpdGlvbjogYWJzb2x1dGU7XHJcbn1cclxuXHJcbkBrZXlmcmFtZXMgYWRkSWNvbiB7XHJcbiAgIDAlICB7Y29sb3I6dHJhbnNwYXJlbnQ7IGZvbnQtc2l6ZTogMGVtO31cclxuICA1MCUgIHsgZm9udC1zaXplOjEuMjVlbTt9XHJcbiAgMTAwJSB7Y29sb3I6d2hpdGVzbW9rZTsgZm9udC1zaXplOiAwLjc1ZW07fVxyXG59XHJcbi8qXHJcbkBrZXlmcmFtZXMgYWRkSWNvbiB7XHJcbiAgIDAlICB7Y29sb3I6dHJhbnNwYXJlbnQ7IHRvcDotMTBweDt9XHJcbiAgNzUlICB7IHRvcDoyMHB4O31cclxuICAxMDAlIHtjb2xvcjpkYXJrZ3JlZW47IHRvcDoxMHB4O31cclxufS8qKi9cclxuXHJcbi5jb21wb25lbnQtY29udGFpbmVyIHtcclxuICAgd2lkdGg6IDEwMCU7XHJcbiAgIGJvcmRlci1yYWRpdXM6IDAgMCA1cHggNXB4O1xyXG4gICBtaW4taGVpZ2h0OiA0ZW07XHJcbiAgIGRpc3BsYXk6IGZsZXg7XHJcbn1cclxuXHJcbi5jYXJkLXRvcC1jb250YWluZXIge1xyXG4gICBkaXNwbGF5OiBub25lO1xyXG4gICBoZWlnaHQ6IDBlbTtcclxufVxyXG5cclxuLmNhcmQtcGFydDpob3ZlciB7XHJcbiAgIHRyYW5zaXRpb246IDBzO1xyXG59XHJcblxyXG4uY2FyZC1wYXJ0IGkge1xyXG4gICBjb2xvcjogZ3JheTtcclxuICAgZm9udC1zaXplOiAyZW07XHJcbn1cclxuXHJcbi5idXR0b24taWNvbiB7XHJcbiAgIGNvbG9yOiBncmF5O1xyXG4gICBmb250LXNpemU6IDJlbTtcclxufVxyXG5cclxuLnBhcnQtY2VudGVyIHtcclxuICAgd2lkdGg6IDM0LjUlO1xyXG4gICBib3JkZXItcmFkaXVzOiAwO1xyXG59XHJcblxyXG4ucGFydC1sZWZ0IHtcclxuICAgYm9yZGVyLXJhZGl1czogMCAwIDAgNXB4O1xyXG4gICB3aWR0aDogMzMlO1xyXG59XHJcblxyXG4ucGFydC1yaWdodCB7XHJcbiAgIGJvcmRlci1yYWRpdXM6IDAgMCA1cHggMDtcclxuICAgd2lkdGg6IDMzJTtcclxufVxyXG5cclxuLmNhdGVnb3J5LWljb24ge1xyXG4gICBwb3NpdGlvbjogYWJzb2x1dGU7XHJcbiAgIHRvcDogMTBweDtcclxuICAgbGVmdDogMTBweDtcclxufVxyXG5cclxuLmNhcmQtYm9keSB7XHJcbiAgIGJvcmRlci1yYWRpdXM6IDVweDtcclxufVxyXG5cclxuLmJnLWZyYW1lLW5vbm9idGFpbmVkIHtcclxuICAgY29sb3I6IGRhcmtncmF5O1xyXG59XHJcblxyXG4uY2FyZC10aXRsZSB7XHJcbiAgIHBvc2l0aW9uOmFic29sdXRlO1xyXG4gICBsZWZ0OiA1MCU7XHJcbiAgIHRvcDogNTAlO1xyXG4gICB0cmFuc2Zvcm06IHRyYW5zbGF0ZSgtNTAlLCAtNTAlKTtcclxuICAgZm9udC1zaXplOiAxLjI1ZW07XHJcbiAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgdmVydGljYWwtYWxpZ246IGNlbnRlcjtcclxufVxyXG5cclxuLnRvb2x0aXAtdGV4dCB7XHJcbiAgIHZpc2liaWxpdHk6IGhpZGRlbjtcclxuICAgcG9zaXRpb246IGFic29sdXRlO1xyXG4gICB3aWR0aDogMTIwcHg7XHJcbiAgIC8vIGRpc3BsYXk6IG5vbmU7XHJcbiAgIGZvbnQtc2l6ZTogMC41ZW07XHJcbiAgIGZvbnQtd2VpZ2h0OiBub3JtYWw7XHJcbiAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgYm9yZGVyLXJhZGl1czogMnB4O1xyXG4gICBwYWRkaW5nOiA1cHggNXB4O1xyXG4gICB6LWluZGV4OiAxO1xyXG4gICB0cmFuc2Zvcm06dHJhbnNsYXRlKC03N3B4LCA0MHB4KTtcclxuICAgYmFja2dyb3VuZC1jb2xvcjogd2hpdGVzbW9rZTtcclxuICAgYm9yZGVyOiBzb2xpZCAxcHggYmxhY2s7XHJcbiAgIGJveC1zaGFkb3c6IDJweCAycHggM3B4IGJsYWNrO1xyXG59XHJcblxyXG4gQG1lZGlhIG9ubHkgc2NyZWVuIGFuZCAobWluLXdpZHRoOiA5OTJweCkge1xyXG4gICAuY2FyZC1wYXJ0IGkge1xyXG4gICAgICB2aXNpYmlsaXR5OiBoaWRkZW47XHJcbiAgICAgIGNvbG9yOiByZ2IoMTIxLCAxMjEsIDEyMSk7XHJcbiAgIH1cclxuICAgLmNhcmQtcGFydDpob3ZlciBpIHtcclxuICAgICAgdmlzaWJpbGl0eTogdmlzaWJsZTtcclxuICAgfVxyXG5cclxuICAgLmNhcmQtYm90dG9tLWNvbnRhaW5lciB7XHJcbiAgICAgIGRpc3BsYXk6IGZsZXg7XHJcbiAgICAgIG1pbi1oZWlnaHQ6IDJlbTtcclxuICAgfVxyXG4gICBcclxuICAgLmNhcmQtdG9wLWNvbnRhaW5lciB7XHJcbiAgICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcclxuICAgICAgbWluLWhlaWdodDogNGVtO1xyXG4gICB9XHJcbi8qKi9cclxuXHJcbiAgIC5jYXJkLXRpdGxlIHtcclxuICAgICAgcG9zaXRpb246YWJzb2x1dGU7XHJcbiAgICAgIGxlZnQ6IDUwJTtcclxuICAgICAgdG9wOiA1MCU7XHJcbiAgICAgIHRyYW5zZm9ybTogdHJhbnNsYXRlKC01MCUsIC01MCUpO1xyXG4gICAgICBmb250LXNpemU6IDEuMjVlbTtcclxuICAgICAgd2lkdGg6IDgwJTtcclxuICAgICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG4gICAgICB2ZXJ0aWNhbC1hbGlnbjogY2VudGVyO1xyXG4gICB9LyoqL1xyXG4gICAgXHJcbiAgICAuY2FyZC1wYXJ0OmhvdmVyIC50b29sdGlwLXRleHQge1xyXG4gICAgICB2aXNpYmlsaXR5OiB2aXNpYmxlO1xyXG4gICAgfVxyXG59Il19 */"] });


/***/ }),

/***/ "pW6c":
/*!*****************************************************!*\
  !*** ./src/app/_services/authentication.service.ts ***!
  \*****************************************************/
/*! exports provided: AuthenticationService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthenticationService", function() { return AuthenticationService; });
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/common/http */ "tk/3");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ "qCKp");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs/operators */ "kU1M");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../environments/environment */ "AytR");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ "fXoL");






class AuthenticationService {
    constructor(http) {
        this.http = http;
        this.authenticateUrl = _environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].apiUrl + "/user";
        this.httpOptions = {
            headers: new _angular_common_http__WEBPACK_IMPORTED_MODULE_0__["HttpHeaders"]({
                'Content-Type': 'application/json',
                Authorization: ''
            })
        };
        let storedCurrentUser = localStorage.getItem('currentUser');
        if (storedCurrentUser != null) {
            let currentUser = new rxjs__WEBPACK_IMPORTED_MODULE_1__["BehaviorSubject"](JSON.parse(storedCurrentUser));
            if (currentUser != null)
                this.currentUserSubject = currentUser;
            this.currentUser = this.currentUserSubject.asObservable();
        }
    }
    login(userName, password) {
        var url = _environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].apiUrl + "/user/login";
        this.http.post(url, { userName, password }, { withCredentials: true })
            .subscribe(response => { });
    }
    register(userName, password) {
        console.log("Registering", userName);
        var url = _environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].apiUrl + "/user/register";
        return this.http.post(url, { userName, password }, { withCredentials: true })
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(user => {
            console.log(user);
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
        }));
    }
}
AuthenticationService.ɵfac = function AuthenticationService_Factory(t) { return new (t || AuthenticationService)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_0__["HttpClient"])); };
AuthenticationService.ɵprov = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjectable"]({ token: AuthenticationService, factory: AuthenticationService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ "qwLP":
/*!**************************************************************!*\
  !*** ./src/app/_components/wish-list/wish-list.component.ts ***!
  \**************************************************************/
/*! exports provided: WishListComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WishListComponent", function() { return WishListComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../_services */ "J9tS");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ofXK");
/* harmony import */ var _wish_list_card_wish_list_card_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./wish-list-card/wish-list-card.component */ "T7zK");





function WishListComponent_li_4_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "li", 2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](1, "app-wish-list-card", 3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const collectible_r1 = ctx.$implicit;
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("collectible", collectible_r1)("onDelete", ctx_r0.removeItem);
} }
class WishListComponent {
    constructor(collectibleService, blueprintService) {
        this.collectibleService = collectibleService;
        this.blueprintService = blueprintService;
        this.collectibles = [];
        this.blueprints = [];
        this.resourceCosts = [];
        this._searchForm = {
            includeFrames: true,
            includePrimaryWeapons: true,
            includeSecondaryWeapons: true,
            includeMeleeWeapons: true,
            includePets: true,
            includeRoboWeapons: true,
            includeOperatorAmps: true,
            includeArchwings: true,
            includeArchGuns: true,
            includeArchMeleeWeapons: true,
            onlyOnWishlist: true,
            includeOwned: true,
            includeMastered: true,
            searchText: ""
        };
        this.removeItem = this.removeItem.bind(this);
    }
    ngOnInit() {
        this.getCollectibles();
    }
    getBlueprintComponents(name) {
        let blueprint = this.blueprints.find(blueprint => blueprint.resultName === name);
        return blueprint === undefined ? [] : blueprint.components;
    }
    getBlueprint(resultName) {
        let result = this.blueprints.find(blueprint => blueprint.resultName === resultName);
        return result === undefined ? { resultName: "Null", components: [] } : result;
    }
    getBlueprintResourceCost(name) {
        let cost = this.resourceCosts.find(cost => cost.name === name);
        return cost === undefined ? { name: name, cost: [] } : cost;
    }
    removeItem(name) {
        let index = this.collectibles.findIndex(collectible => collectible.name === name);
        if (index > -1) {
            this.collectibles.splice(index, 1);
        }
        index = this.resourceCosts.findIndex(stack => stack.name === name);
        if (index > -1) {
            this.resourceCosts.splice(index, 1);
        }
    }
    getTotalCost() {
        let result = [];
        for (let n = 0; n < this.resourceCosts.length; n++) {
            for (let i = 0; i < this.resourceCosts[n].cost.length; i++) {
                let stack = this.resourceCosts[n].cost[i];
                let existingStack = result.findIndex(s => s.name === stack.name);
                if (existingStack > -1) {
                    result[existingStack].amount += stack.amount;
                }
                else {
                    result.push({ id: stack.id, name: stack.name, amount: stack.amount });
                }
            }
        }
        let creditsIndex = result.findIndex(stack => stack.name === "Credits");
        if (creditsIndex > -1) {
            let credits = result[creditsIndex];
            result.splice(creditsIndex, 1);
            result.splice(0, 0, credits);
        }
        return result;
    }
    hasResourceCost() {
        return this.getTotalCost().length > 0;
    }
    getCollectibles() {
        this.collectibleService.getCollectibles(this._searchForm)
            .subscribe(collectibles => {
            this.collectibles = collectibles;
            this.getBlueprints();
            this.getCosts();
        });
    }
    getBlueprints() {
        this.blueprints = [];
        this.collectibles.forEach(collectible => {
            this.blueprintService.getBlueprintsWithResult(collectible.name)
                .subscribe(components => {
                let blueprint = {
                    resultName: collectible.name,
                    components: components.map(component => {
                        return {
                            name: component.componentName,
                            componentCount: component.componentCount
                        };
                    })
                };
                this.blueprints.push(blueprint);
            });
        });
    }
    getCosts() {
        this.resourceCosts = [];
        this.collectibles.forEach(collectible => {
            this.blueprintService.getTotalResourceCost(collectible.name)
                .subscribe(costs => {
                let blueprintCost = {
                    name: collectible.name,
                    cost: costs.map(stack => {
                        return {
                            id: stack.id,
                            name: stack.name,
                            amount: stack.amount
                        };
                    })
                };
                this.resourceCosts.push(blueprintCost);
            });
        });
    }
}
WishListComponent.ɵfac = function WishListComponent_Factory(t) { return new (t || WishListComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_1__["CollectibleService"]), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_1__["BlueprintService"])); };
WishListComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: WishListComponent, selectors: [["app-wish-list"]], decls: 5, vars: 1, consts: [[1, "list-group"], ["class", "list-group-item wish-list-item", 4, "ngFor", "ngForOf"], [1, "list-group-item", "wish-list-item"], [3, "collectible", "onDelete"]], template: function WishListComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h1");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Wish list");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "ul", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](4, WishListComponent_li_4_Template, 2, 2, "li", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx.collectibles);
    } }, directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["NgForOf"], _wish_list_card_wish_list_card_component__WEBPACK_IMPORTED_MODULE_3__["WishListCardComponent"]], styles: [".component-box[_ngcontent-%COMP%] {\n  border: 1px solid gray;\n}\n\n.wish-list-item[_ngcontent-%COMP%]:hover {\n  background-color: #cbd9db;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFx3aXNoLWxpc3QuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRyxzQkFBQTtBQUNIOztBQUVBO0VBQ0cseUJBQUE7QUFDSCIsImZpbGUiOiJ3aXNoLWxpc3QuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuY29tcG9uZW50LWJveCB7XHJcbiAgIGJvcmRlcjogMXB4IHNvbGlkIGdyYXk7XHJcbn1cclxuXHJcbi53aXNoLWxpc3QtaXRlbTpob3ZlciB7XHJcbiAgIGJhY2tncm91bmQtY29sb3I6IHJnYigyMDMsIDIxNywgMjE5KTtcclxufSJdfQ== */"] });


/***/ }),

/***/ "rGDM":
/*!**************************************!*\
  !*** ./src/app/_interfaces/index.ts ***!
  \**************************************/
/*! exports provided: collectibleCategories, collectibleCategoryKeys, obtainedState */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _collectible__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./collectible */ "dRa/");
/* empty/unused harmony star reexport *//* harmony import */ var _collectibleCategories__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./collectibleCategories */ "SPnD");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "collectibleCategories", function() { return _collectibleCategories__WEBPACK_IMPORTED_MODULE_1__["collectibleCategories"]; });

/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "collectibleCategoryKeys", function() { return _collectibleCategories__WEBPACK_IMPORTED_MODULE_1__["collectibleCategoryKeys"]; });

/* harmony import */ var _collectibleSearchForm__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./collectibleSearchForm */ "Zk0c");
/* empty/unused harmony star reexport *//* harmony import */ var _obtainedState__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./obtainedState */ "/1go");
/* harmony reexport (safe) */ __webpack_require__.d(__webpack_exports__, "obtainedState", function() { return _obtainedState__WEBPACK_IMPORTED_MODULE_3__["obtainedState"]; });

/* harmony import */ var _blueprint__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./blueprint */ "aGj9");
/* empty/unused harmony star reexport */






/***/ }),

/***/ "vY5A":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/router */ "tyNb");
/* harmony import */ var _components_login__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./_components/login */ "5iIw");
/* harmony import */ var _register__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./register */ "lZQ7");
/* harmony import */ var _components__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./_components */ "Ndrk");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ "fXoL");






const routes = [
    { path: 'collectibles', component: _components__WEBPACK_IMPORTED_MODULE_3__["CollectiblesComponent"] },
    { path: '', redirectTo: '/collectibles', pathMatch: 'full' },
    { path: 'login', component: _components_login__WEBPACK_IMPORTED_MODULE_1__["LoginComponent"] },
    { path: 'register', component: _register__WEBPACK_IMPORTED_MODULE_2__["RegisterComponent"] },
    { path: 'wishlist', component: _components__WEBPACK_IMPORTED_MODULE_3__["WishListComponent"] },
    { path: 'collectible/:category/:name', component: _components__WEBPACK_IMPORTED_MODULE_3__["DetailsComponent"] }
];
class AppRoutingModule {
}
AppRoutingModule.ɵfac = function AppRoutingModule_Factory(t) { return new (t || AppRoutingModule)(); };
AppRoutingModule.ɵmod = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineNgModule"]({ type: AppRoutingModule });
AppRoutingModule.ɵinj = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjector"]({ imports: [[_angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"].forRoot(routes)], _angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"]] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵsetNgModuleScope"](AppRoutingModule, { imports: [_angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"]], exports: [_angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"]] }); })();


/***/ }),

/***/ "zIHm":
/*!**********************************************************!*\
  !*** ./src/app/_components/details/details.component.ts ***!
  \**********************************************************/
/*! exports provided: DetailsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DetailsComponent", function() { return DetailsComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "tyNb");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ofXK");
/* harmony import */ var _services__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../_services */ "J9tS");





function DetailsComponent_div_0_div_22_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const resource_r3 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate2"](" ", resource_r3.name, " (", resource_r3.amount, ") ");
} }
function DetailsComponent_div_0_Template(rf, ctx) { if (rf & 1) {
    const _r5 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵgetCurrentView"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 5);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "h1");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](4, "h2");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](5);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "div", 6);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "h5", 2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](8);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "button", 7);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function DetailsComponent_div_0_Template_button_click_9_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵrestoreView"](_r5); const ctx_r4 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"](); return ctx_r4.toggleWishlist(); });
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](10, "Toggle");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "div", 6);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](12, "h5", 2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](13);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](14, "div", 8);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](15, "button", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function DetailsComponent_div_0_Template_button_click_15_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵrestoreView"](_r5); const ctx_r6 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"](); return ctx_r6.reduceRank(); });
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, "-");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "button", 9);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function DetailsComponent_div_0_Template_button_click_17_listener() { _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵrestoreView"](_r5); const ctx_r7 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"](); return ctx_r7.increaseRank(); });
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](18, "+");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](19, "div", 6);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](20, "h5");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](21, "Build cost");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](22, DetailsComponent_div_0_div_22_Template, 2, 2, "div", 10);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const ctx_r0 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](ctx_r0.collectible.name);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](ctx_r0.collectible.category);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"]("Wishlist: ", ctx_r0.wishlistText, "");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](5);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"]("Status: ", ctx_r0.statusText, "");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](9);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx_r0.cost);
} }
function DetailsComponent_div_5_div_5_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const resource_r12 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate2"](" ", resource_r12.name, " (", resource_r12.amount, ") ");
} }
function DetailsComponent_div_5_h5_6_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "h5");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "Location");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} }
function DetailsComponent_div_5_div_7_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const source_r13 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate3"](" ", source_r13.sourceName, " (", source_r13.sourceType, ", ", source_r13.value, ") ");
} }
function DetailsComponent_div_5_Template(rf, ctx) { if (rf & 1) {
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 11);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h4");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "h5");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4, "Build cost");
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](5, DetailsComponent_div_5_div_5_Template, 2, 2, "div", 10);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](6, DetailsComponent_div_5_h5_6_Template, 2, 0, "h5", 12);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](7, DetailsComponent_div_5_div_7_Template, 2, 3, "div", 10);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
} if (rf & 2) {
    const component_r8 = ctx.$implicit;
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](component_r8.resource.componentName);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](3);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", component_r8.cost);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngIf", component_r8.source.length > 0);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
    _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", component_r8.source);
} }
class DetailsComponent {
    constructor(route, location, collectibleService, blueprintService) {
        this.route = route;
        this.location = location;
        this.collectibleService = collectibleService;
        this.blueprintService = blueprintService;
        this.blueprint = [];
        this.cost = [];
        this.initialisedCollectible = false;
    }
    get name() { return String(this.route.snapshot.paramMap.get('name')); }
    get category() { return String(this.route.snapshot.paramMap.get('category')); }
    ngOnInit() {
        this.getCollectible();
        this.getComponents();
        this.getCost();
    }
    get statusText() {
        if (this.collectible == null)
            return "";
        return this.collectible.mastered ? "Mastered" :
            this.collectible.obtained ? "Obtained" : "Not obtained";
    }
    increaseRank() {
        if (!this.collectible.obtained) {
            this.collectible.obtained = true;
        }
        else if (!this.collectible.mastered) {
            this.collectible.mastered = true;
        }
        else
            return;
        this.updateCollectible();
    }
    reduceRank() {
        if (this.collectible.mastered) {
            this.collectible.mastered = false;
        }
        else if (this.collectible.obtained) {
            this.collectible.obtained = false;
        }
        else
            return;
        this.updateCollectible();
    }
    addToWishlist() {
        this.collectible.onWishlist = true;
        this.updateCollectible();
    }
    removeFromWishlist() {
        this.collectible.onWishlist = false;
        this.updateCollectible();
    }
    toggleWishlist() {
        let onWishlist = this.collectible.onWishlist;
        if (onWishlist)
            this.removeFromWishlist();
        else
            this.addToWishlist();
    }
    get wishlistText() {
        return this.collectible.onWishlist ? "Yes" : "No";
    }
    getCollectible() {
        const category = this.category;
        const name = this.name;
        this.collectibleService.getCollectible(category, name)
            .subscribe(collectible => {
            this.collectible = collectible;
            this.initialisedCollectible = true;
        });
    }
    getComponents() {
        const name = this.name;
        this.blueprintService.getBlueprintsWithResult(name)
            .subscribe(blueprint => {
            this.blueprint = blueprint
                .map(component => {
                return { resource: component, cost: [], source: [] };
            });
            this.blueprint.forEach(component => {
                this.getCostOfComponent(component);
                this.getComponentSource(component);
            });
        });
    }
    getCost() {
        const name = this.name;
        this.blueprintService.getTotalResourceCost(name)
            .subscribe(cost => this.cost = cost);
    }
    getCostOfComponent(component) {
        this.blueprintService
            .getTotalResourceCost(component.resource.componentName)
            .subscribe(cost => component.cost = cost);
    }
    getComponentSource(component) {
        this.blueprintService
            .getSource(component.resource.componentName + " Blueprint")
            .subscribe(source => component.source = source);
    }
    updateCollectible() {
        this.collectibleService.updateCollectible(this.collectible)
            .subscribe(() => { });
    }
}
DetailsComponent.ɵfac = function DetailsComponent_Factory(t) { return new (t || DetailsComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_1__["ActivatedRoute"]), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_common__WEBPACK_IMPORTED_MODULE_2__["Location"]), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_3__["CollectibleService"]), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_services__WEBPACK_IMPORTED_MODULE_3__["BlueprintService"])); };
DetailsComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: DetailsComponent, selectors: [["app-details"]], decls: 6, vars: 2, consts: [["class", "d-flex info-box m-3", 4, "ngIf"], [1, "card", "p-2", "m-3"], [1, "card-title"], [1, "list-group", "list-group-flush"], ["class", "list-group-item", 4, "ngFor", "ngForOf"], [1, "d-flex", "info-box", "m-3"], [1, "card", "p-2"], [1, "btn", "btn-warning", 3, "click"], [1, "d-flex"], [1, "btn", "btn-primary", "large-text", "m-1", 3, "click"], [4, "ngFor", "ngForOf"], [1, "list-group-item"], [4, "ngIf"]], template: function DetailsComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](0, DetailsComponent_div_0_Template, 23, 5, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "h2", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3, "Components");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](4, "ul", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](5, DetailsComponent_div_5_Template, 8, 4, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngIf", ctx.initialisedCollectible);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx.blueprint);
    } }, directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["NgIf"], _angular_common__WEBPACK_IMPORTED_MODULE_2__["NgForOf"]], styles: [".large-text[_ngcontent-%COMP%] {\n  font-size: 2em;\n}\n\n.info-box[_ngcontent-%COMP%]    > *[_ngcontent-%COMP%] {\n  margin-right: 2.5%;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uXFwuLlxcLi5cXC4uXFxkZXRhaWxzLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0csY0FBQTtBQUNIOztBQUVBO0VBQ0csa0JBQUE7QUFDSCIsImZpbGUiOiJkZXRhaWxzLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmxhcmdlLXRleHQge1xyXG4gICBmb250LXNpemU6IDJlbTtcclxufVxyXG5cclxuLmluZm8tYm94ID4gKiB7XHJcbiAgIG1hcmdpbi1yaWdodDogMi41JTtcclxufVxyXG5cclxuLmNvbXBvbmVudC1ib3gge1xyXG5cclxufSJdfQ== */"] });


/***/ }),

/***/ "zUnb":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser */ "jhN1");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "ZAI4");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "AytR");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["enableProdMode"])();
}
_angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["platformBrowser"]().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(err => console.error(err));


/***/ }),

/***/ "zn8P":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "zn8P";

/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map