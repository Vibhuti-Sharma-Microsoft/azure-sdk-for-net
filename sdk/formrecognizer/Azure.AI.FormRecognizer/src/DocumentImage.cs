﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentImage
    {
        /// <summary>
        /// Initializes a new instance of DocumentImage. Used for the <see cref="DocumentAnalysisModelFactory"/>.
        /// </summary>
        internal DocumentImage(IReadOnlyList<PointF> boundingPolygon, DocumentSpan span, int pageNumber, float confidence)
        {
            BoundingPolygon = boundingPolygon;
            Span = span;
            PageNumber = pageNumber;
            Confidence = confidence;
        }

        /// <summary>
        /// The polygon that outlines the content of this image. Coordinates are specified relative to the
        /// top-left of the page, and points are ordered clockwise from the left relative to the word
        /// orientation. Units are in pixels for images and inches for PDF. The <see cref="DocumentPageLengthUnit"/>
        /// type of a recognized page can be found at <see cref="DocumentPage.Unit"/>.
        /// </summary>
        public IReadOnlyList<PointF> BoundingPolygon { get; private set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IReadOnlyList<float> Polygon
        {
            get => throw new InvalidOperationException();
            set
            {
                BoundingPolygon = ClientCommon.ConvertToListOfPointF(value);
            }
        }
    }
}
