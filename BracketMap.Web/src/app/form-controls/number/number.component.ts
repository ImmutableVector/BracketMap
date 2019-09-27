import { Component, forwardRef, Input } from '@angular/core';
import { NG_VALUE_ACCESSOR, ControlValueAccessor } from '@angular/forms';

@Component({
  selector: 'bm-number[label][name]',
  templateUrl: './number.component.html',
  styleUrls: ['./number.component.scss'],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => NumberComponent),
      multi: true
    }
  ]
})
export class NumberComponent implements ControlValueAccessor {
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

  writeValue(value: any): void {
    if (value === null) {
      this.model = value;
    }

    if (typeof value === 'number') {
      throw new Error('form control expects a number');
    }

    this.model = value;
  }
}
