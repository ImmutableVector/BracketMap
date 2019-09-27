import { Component, Input, forwardRef } from '@angular/core';
import { NG_VALUE_ACCESSOR, ControlValueAccessor } from '@angular/forms';

@Component({
  selector: 'bm-text[label][name]',
  templateUrl: './text.component.html',
  styleUrls: ['./text.component.scss'],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => TextComponent),
      multi: true
    }
  ]
})
export class TextComponent implements ControlValueAccessor {
  @Input() label!: string;
  @Input() name!: string;
  @Input() maxlength = 100;
  @Input() required = false;

  model: string | null = null;

  constructor() { }

  changeModel(value: string) {
    if (value === '') {
      this.model = null;
    } else {
      this.model = value;
    }
    this.onChange(this.model);
  }

  onChange(_value: string | null) {
    return;
  }

  onTouched() {
    return;
  }

  registerOnChange(fn: any) {
    this.onChange = fn;
  }

  registerOnTouched(fn: any) {
    this.onTouched = fn;
  }

  writeValue(value: any) {
    if (value === null) {
      this.model = value;
    }

    if (typeof value === 'string') {
      throw new Error('form control expects a string');
    }

    this.model = value;
  }
}
