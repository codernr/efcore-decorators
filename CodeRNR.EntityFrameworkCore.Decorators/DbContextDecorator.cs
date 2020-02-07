using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CodeRNR.EntityFrameworkCore.Decorators
{
    public class DbContextDecorator : IDbContext
    {
        private readonly DbContext dbContext;

        public DbContextDecorator(DbContext dbContext) => this.dbContext = dbContext;

        public virtual ChangeTracker ChangeTracker => this.dbContext.ChangeTracker;

        public virtual DatabaseFacade Database => this.dbContext.Database;

        public virtual DbContextId ContextId => this.dbContext.ContextId;

        public virtual EntityEntry Add(object entity) => this.dbContext.Add(entity);

        public virtual EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class => this.dbContext.Add(entity);

        public virtual ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default) =>
            this.dbContext.AddAsync(entity, cancellationToken);

        public virtual ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class =>
            this.dbContext.AddAsync(entity, cancellationToken);

        public virtual void AddRange(params object[] entities) => this.dbContext.AddRange(entities);

        public virtual void AddRange(IEnumerable<object> entities) => this.dbContext.AddRange(entities);

        public virtual Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default) =>
            this.dbContext.AddRangeAsync(entities, cancellationToken);

        public virtual Task AddRangeAsync(params object[] entities) => this.dbContext.AddRangeAsync(entities);

        public virtual EntityEntry Attach(object entity) => this.dbContext.Attach(entity);

        public virtual EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class => this.dbContext.Attach(entity);

        public virtual void AttachRange(IEnumerable<object> entities) => this.dbContext.AttachRange(entities);

        public virtual void AttachRange(params object[] entities) => this.dbContext.AttachRange(entities);

        public virtual void Dispose() => this.dbContext.Dispose();

        public virtual ValueTask DisposeAsync() => this.dbContext.DisposeAsync();

        public virtual EntityEntry Entry(object entity) => this.dbContext.Entry(entity);

        public virtual EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class => this.dbContext.Entry(entity);

        public virtual TEntity Find<TEntity>(params object[] keyValues) where TEntity : class => this.dbContext.Find<TEntity>(keyValues);

        public virtual object Find(Type entityType, params object[] keyValues) => this.dbContext.Find(entityType, keyValues);

        public virtual ValueTask<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken) =>
            this.dbContext.FindAsync(entityType, keyValues, cancellationToken);

        public virtual ValueTask<object> FindAsync(Type entityType, params object[] keyValues) => this.dbContext.FindAsync(entityType, keyValues);

        public virtual ValueTask<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class =>
            this.dbContext.FindAsync<TEntity>(keyValues, cancellationToken);

        public virtual ValueTask<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class => this.dbContext.FindAsync<TEntity>(keyValues);

        [Obsolete("Use Set() for entity types without keys")]
        public virtual DbQuery<TQuery> Query<TQuery>() where TQuery : class => this.dbContext.Query<TQuery>();

        public virtual EntityEntry Remove(object entity) => this.dbContext.Remove(entity);

        public virtual EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class => this.dbContext.Remove(entity);

        public virtual void RemoveRange(IEnumerable<object> entities) => this.dbContext.RemoveRange(entities);

        public virtual void RemoveRange(params object[] entities) => this.dbContext.RemoveRange(entities);

        public virtual int SaveChanges(bool acceptAllChangesOnSuccess) => this.dbContext.SaveChanges(acceptAllChangesOnSuccess);

        public virtual int SaveChanges() => this.dbContext.SaveChanges();

        public virtual Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default) =>
            this.dbContext.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => this.dbContext.SaveChangesAsync(cancellationToken);

        public virtual DbSet<TEntity> Set<TEntity>() where TEntity : class => this.dbContext.Set<TEntity>();

        public virtual EntityEntry Update(object entity) => this.dbContext.Update(entity);

        public virtual EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class => this.dbContext.Update(entity);

        public virtual void UpdateRange(IEnumerable<object> entities) => this.dbContext.UpdateRange(entities);

        public virtual void UpdateRange(params object[] entities) => this.dbContext.UpdateRange(entities);
    }
}