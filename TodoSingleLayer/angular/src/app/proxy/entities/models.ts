import type { BasicAggregateRoot } from '../volo/abp/domain/entities/models';

export interface User extends BasicAggregateRoot<string> {
  name?: string;
  age?: number;
}
