﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Slack.NetStandard.WebApi.Admin;

namespace Slack.NetStandard.WebApi
{
    public interface IAdminAppsApi
    {
        Task<WebApiResponse> ApproveApp(string appId, string teamId = null, string enterpriseId = null);
        Task<WebApiResponse> ApproveRequest(string requestId, string teamId = null, string enterpriseId = null);
        Task<WebApiResponse> RestrictApp(string appId, string teamId = null, string enterpriseId = null);
        Task<WebApiResponse> RestrictRequest(string requestId, string teamId = null, string enterpriseId = null);
        Task<WebApiResponse> CancelRequest(string requestId, string teamId = null, string enterpriseId = null);

        Task<ListAppRequestResponse> ListAppRequests(TeamRequestFilter filters);
        Task<ListApprovedAppResponse> ListApprovedApps(TeamFilter filters);
        Task<ListRestrictedAppResponse> ListRestrictedApps(TeamFilter filters);
    }
}
