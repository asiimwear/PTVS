/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Flavor;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.PythonTools.Uwp.Project {
    [Guid(GuidList.guidUwpFactoryString)]
    public class PythonUwpProjectFactory : FlavoredProjectFactoryBase {
        private PythonUwpPackage _package;

        public PythonUwpProjectFactory(PythonUwpPackage package) {
            _package = package;
        }

        protected override object PreCreateForOuter(IntPtr outerProjectIUnknown) {
            return new PythonUwpProject { Package = _package };
        }
    }
}