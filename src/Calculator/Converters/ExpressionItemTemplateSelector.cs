// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using CalculatorApp.ViewModel.Common;

using System;

using Microsoft.UI.Xaml;

namespace CalculatorApp
{
    namespace Converters
    {
        [Microsoft.UI.Xaml.Data.Bindable]
        public sealed class ExpressionItemTemplateSelector : Microsoft.UI.Xaml.Controls.DataTemplateSelector
        {
            protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
            {
                if (item is DisplayExpressionToken token)
                {
                    CalculatorApp.ViewModel.Common.TokenType type = token.Type;

                    switch (type)
                    {
                        case TokenType.Operator:
                            return OperatorTemplate;
                        case TokenType.Operand:
                            return OperandTemplate;
                        case TokenType.Separator:
                            return SeparatorTemplate;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(type), type, "Invalid token type");
                    }
                }

                return SeparatorTemplate;
            }

            public Microsoft.UI.Xaml.DataTemplate OperatorTemplate { get; set; }

            public Microsoft.UI.Xaml.DataTemplate OperandTemplate { get; set; }

            public Microsoft.UI.Xaml.DataTemplate SeparatorTemplate { get; set; }
        }
    }
}

