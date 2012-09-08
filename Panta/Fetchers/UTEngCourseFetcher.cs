﻿using Panta.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panta.Fetchers
{
    public class UTEngCourseFetcher : IItemFetcher<Course>
    {
        public string Url
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Course> FetchItems()
        {
            return new UTEngCourseInfoFetcher(@"http://www.apsc.utoronto.ca/timetable/winter.html").FetchItems();
        }
    }
}
