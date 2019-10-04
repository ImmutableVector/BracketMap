import { Component, forwardRef, Input } from '@angular/core';
import { NG_VALUE_ACCESSOR, ControlValueAccessor, Validator, NG_VALIDATORS, ValidationErrors } from '@angular/forms';

@Component({
  selector: 'bm-number[label][name]',
  templateUrl: './number.component.html',
  styleUrls: ['./number.component.scss'],
  providers: [
    {
      provide: NG_VALIDATORS,
      useExisting: forwardRef(() => NumberComponent),
      multi: true
    },
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => NumberComponent),
      multi: true
    }
  ]
})
export class NumberComponent implements ControlValueAccessor, Validator {
  @Input() label!: string;
  @Input() name!: string;
  @Input() max = 100;
  @Input() min = 0;
  @Input() required = false;

  model: number | null = null;

  constructor() { }

  changeModel(value: number | null) {
    this.model = value;
    this.onChange(this.model);
  }

  onlyUpDown(event: KeyboardEvent) {
    if (event.code !== 'ArrowUp' && event.code !== 'ArrowDown') {
      event.preventDefault();
    }
  }

  onChange(_value: number | null) {
    return;
  }

  onTouched() {
    return;
  }

  registerOnChange(fn: any): void {
    this.onChange = fn;
  }

  registerOnTouched(fn: any): void {
    this.onTouched = fn;
  }

  validate(): ValidationErrors | null {
    if (this.model === null) {
      if (this.required) {
        return { required: true };
      }
      return null;
    }

    if (this.model > this.max) {
      return { max: true };
    }

    if (this.model < this.min) {
      return { min: true };
    }

    return null;
  }

  writeValue(value: any): void {
    if (value === null) {
      this.model = value;
      return;
    }

    if (typeof value !== 'number') {
      throw new Error('form control expects a number');
    }

    this.model = value;
  }
}
