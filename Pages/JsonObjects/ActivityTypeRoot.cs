﻿using System.Collections.Generic;

namespace Garmin_To_Fitbit_Steps_Sync_Web.Pages.JsonObjects
{

    public class ActivityTypeRoot    {
        public List<Activity> activities { get; set; } 
        public Goals goals { get; set; } 
        public Summary summary { get; set; } 
    
}

}

