// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Contiguous region of the concatenated content property, specified as an offset and length. </summary>
    public readonly partial struct DocumentSpan
    {
        /// <summary> Initializes a new instance of DocumentSpan. </summary>
        /// <param name="index"> Zero-based index of the content represented by the span. </param>
        /// <param name="length"> Number of characters in the content represented by the span. </param>
        internal DocumentSpan(int index, int length)
        {
            Index = index;
            Length = length;
        }
    }
}
