// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ManualHints.cs">
//   Copyright (c) 2018 Aspose.BarCode for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System; 

namespace Aspose.BarCode.Cloud.Sdk.Model 
{
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;
  
  /// <summary>
  /// Represents the usage of manual hints.
  /// </summary>  
  [JsonConverter(typeof(StringEnumConverter))]
  public  enum ManualHints 
  {  	
		/// <summary>
        /// Enum value None
        /// </summary>            
        None,
		
		/// <summary>
        /// Enum value InvertImage
        /// </summary>            
        InvertImage,
		
		/// <summary>
        /// Enum value IncorrectBarCodes
        /// </summary>            
        IncorrectBarCodes,
		
		/// <summary>
        /// Enum value ComplexBackground
        /// </summary>            
        ComplexBackground,
		
		/// <summary>
        /// Enum value MedianSmoothing
        /// </summary>            
        MedianSmoothing,
		
		/// <summary>
        /// Enum value SpecialFormOfCells
        /// </summary>            
        SpecialFormOfCells,
		
		/// <summary>
        /// Enum value UseRegular
        /// </summary>            
        UseRegular,
		
		/// <summary>
        /// Enum value UseRestoration
        /// </summary>            
        UseRestoration,
		
		/// <summary>
        /// Enum value SkipRotatedBarCodes
        /// </summary>            
        SkipRotatedBarCodes
		
  }
}