﻿using AdminLTEPro.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AdminLTEPro.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AdminLTEProController : AbpControllerBase
{
    protected AdminLTEProController()
    {
        LocalizationResource = typeof(AdminLTEProResource);
    }
}
