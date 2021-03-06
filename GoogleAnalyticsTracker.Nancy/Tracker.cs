﻿using GoogleAnalyticsTracker.Core;
using System.Configuration;

namespace GoogleAnalyticsTracker.Nancy
{
    public class Tracker
            : TrackerBase
    {
        public Tracker()
            : this(new AnalyticsSession())
        {
        }

        public Tracker(IAnalyticsSession analyticsSession)
            : this(ConfigurationManager.AppSettings[TrackingAccountConfigurationKey], ConfigurationManager.AppSettings[TrackingDomainConfigurationKey], analyticsSession, new NancyTrackerEnvironment())
        {
        }

        public Tracker(string trackingAccount, string trackingDomain)
            : this(trackingAccount, trackingDomain, new AnalyticsSession(), new NancyTrackerEnvironment())
        {
        }


        public Tracker(string trackingAccount, string trackingDomain, ITrackerEnvironment trackerEnvironment)
            : base(trackingAccount, trackingDomain, trackerEnvironment)
        {
        }

        public Tracker(string trackingAccount, string trackingDomain, IAnalyticsSession analyticsSession, ITrackerEnvironment trackerEnvironment)
            : base(trackingAccount, trackingDomain, analyticsSession, trackerEnvironment)
        {
        }
    }
}
