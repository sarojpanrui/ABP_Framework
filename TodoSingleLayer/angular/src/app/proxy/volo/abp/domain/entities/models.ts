
export interface BasicAggregateRoot<TKey> extends Entity<TKey> {
}

export interface Entity<TKey> {
  id?: TKey;
}
