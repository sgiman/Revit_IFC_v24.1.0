﻿/*******************************************************************************
 * ........
 * 
 * Autodesk Revit 24.0.4.427 (ENU) - IFC 24.1.1.6 (IFC import/Export) 
 * https://github.com/Autodesk/revit-ifc/releases
 *
 * -----------------------------------------------------------------------------
 * Create Build (API REVIT 2024) 
 * Application (add-ins)
 * -----------------------------------------------------------------------------
 * Visual Studio 2022 
 * C# | .NET 4.8
 * ----------------------------------------------------------------------------- 
 * Writing sgiman @ 2023 
 *******************************************************************************/
//
// BIM IFC library: this library works with Autodesk(R) Revit(R) to export IFC files containing model geometry.
// Copyright (C) 2012  Autodesk, Inc.
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
//

using System.Collections.Generic;

namespace RevitIFCTools.PropertySet
{
   class PropertyEnumItem
   {
      public string EnumItem { get; set; }
      public IList<NameAlias> Aliases { get; set; }
   }
}
