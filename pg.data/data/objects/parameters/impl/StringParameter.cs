﻿using pg.data.data.objects.parameters.types;

namespace pg.data.data.objects.parameters.impl
{
    public sealed class StringParameter : AbstractParameter<string>
    {
        public override void SetValueByString(string value)
        {
            SetValue(value.Trim());
        }

        public override string ToString()
        {
            return GetValue();
        }

        public override PetroglyphParameterType GetParameterType()
        {
            return PetroglyphParameterType.StringType;
        }

        public StringParameter(string id) : base(id)
        {
        }
    }
}
