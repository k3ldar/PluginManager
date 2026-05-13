/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *  Plugin Manager is distributed under the GNU General Public License version 3 and  
 *  is also available under alternative licenses negotiated directly with Simon Carter.  
 *  If you obtained Service Manager under the GPL, then the GPL applies to all loadable 
 *  Service Manager modules used on your system as well. The GPL (version 3) is 
 *  available at https://opensource.org/licenses/GPL-3.0
 *
 *  This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
 *  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *  See the GNU General Public License for more details.
 *
 *  The Original Code was created by Simon Carter (s1cart3r@gmail.com)
 *
 *  Copyright (c) 2018 - 2025 Simon Carter.  All Rights Reserved.
 *
 *  Product:  PluginManager.Tests
 *  
 *  File: BadEggPlugin.cs
 *
 *  Purpose:  Mock plugin for testing (simulates a plugin that exists but may be disabled)
 *
 *  Date        Name                Reason
 *  23/01/2025  Simon Carter        Initially Created
 *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.DependencyInjection;

using PluginManager.Abstractions;

namespace PluginManager.Tests.Mocks
{
    [ExcludeFromCodeCoverage]
    public class BadEggPlugin : IPlugin
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Mock implementation - services configuration for BadEgg plugin
        }

        public void Finalise()
        {
            // Mock implementation - cleanup
        }

        public ushort GetVersion()
        {
            return 1;
        }

        public void Initialise(ILogger logger)
        {
            // Mock implementation - initialization
        }
    }
}
