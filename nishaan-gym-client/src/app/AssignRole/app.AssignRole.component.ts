import { Component, OnInit } from '@angular/core';
import { AssignRemoveModel } from './Models/AssignRemoveModel';
import { UserService } from '../CreateUsers/Services/app.UserRegistration.Service';
import { UserDropdownModel } from '../CreateUsers/Models/app.UserDropdownModel';
import { RoleService } from '../RoleMaster/Services/app.role.Service';
import { RoleModel } from '../RoleMaster/Models/app.RoleModel';
import { AssignandRemoveRoleService } from './Services/app.AssignandRemoveRole.Service';
import { Router } from '@angular/router';

@Component({
    templateUrl: './app.AssignandRemoveRole.html',
    styleUrls: ['../Content/vendor/bootstrap/css/bootstrap.min.css',
        '../Content/vendor/metisMenu/metisMenu.min.css',
        '../Content/dist/css/sb-admin-2.css',
        '../Content/vendor/font-awesome/css/font-awesome.min.css'
    ]
})

export class AssignRoleComponent implements OnInit {
    private _userService;
    private _roleService;
    private _assignandRemoveService;
    UserList: UserDropdownModel[];
    AssignRemoveModel: AssignRemoveModel = new AssignRemoveModel();
    RoleList: RoleModel[];

    errorMessage: any;
    output: any;
    constructor(private userService: UserService, private roleService: RoleService,
      private assignandRemoveRoleService: AssignandRemoveRoleService, private route: Router)
        {
        this._userService = userService;
        this._roleService = roleService;
        this._assignandRemoveService = assignandRemoveRoleService;
    }

    ngOnInit(): void
    {
        this._userService.GetAllUsersDropdown().subscribe(
            allUsers => {
                this.UserList = allUsers
            },
            error => this.errorMessage = <any>error
        );

        this._roleService.GetAllRole().subscribe(
            allroles => {
                this.RoleList = allroles
            },
            error => this.errorMessage = <any>error
        );
    }


    onSubmit(buttonType): void {
        if(buttonType === 'onAssign')
        {
            console.log(this.AssignRemoveModel);
            this._assignandRemoveService.AssignRole(this.AssignRemoveModel)
            .subscribe(response =>
                {
                    this.output = response
                    if (this.output.StatusCode == "409") {
                        alert('Role Already Exists');
                    }
                    else if (this.output.StatusCode == "200") {
                        alert('Role Assigned Successfully');
                        this.route.navigate(['/Assign/AllRole']);
                    }
                    else {
                        alert('Something Went Wrong');
                    }
                });
        }

        if(buttonType === 'onRemove')
        {
            this._assignandRemoveService.RemoveRole(this.AssignRemoveModel)
            .subscribe(response =>
                {
                    this.output = response
                    if (this.output.StatusCode == "409") {
                        alert('Role does not Exists');
                    }
                    else if (this.output.StatusCode == "200") {
                        alert('Role Removed Successfully');
                        this.route.navigate(['/Assign/AllRole']);
                    }
                    else {
                        alert('Something Went Wrong');
                    }
                });
        }

}
}
