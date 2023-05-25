﻿namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // file convention: Name.cs - See Example.cs file for weapon property details.
            //
            // Enable your config files using the follow syntax, don't include the ".cs" extension:
            // ConfigFiles(Your1stConfigFile, Your2ndConfigFile, Your3rdConfigFile);

            PartDefinitions(NtechObelisk1, NtechObelisk2, NtechObelisk3, NtechObelisk4, NtechObelisk5);
            ArmorDefinitions();
            SupportDefinitions();
            UpgradeDefinitions();
        }
    }
}