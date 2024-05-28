﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Security_Role")]
public class SecurityRoles
{
    public string? DisplayText { get; set; }
    public bool Active { get; set; }
    public string? Id { get; set; }
}

[Table("Security_User")]
public class SecurityUsers
{
    public string? TenantCode { get; set; }
    public int Client_Id { get; set; }
    public bool Active { get; set; }
    public string? Id { get; set; }
    public string? Email { get; set; }
}

[Table("Security_UserRole")]
public class SecurityUserRoles
{
    public string UserId { get; set; }
    public string RoleId { get; set; }
    public bool Active { get; set; }
    public string Id { get; set; }
}