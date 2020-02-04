Ext.define('Task.store.Personnel', {
    extend: 'Ext.data.Store',

    alias: 'store.personnel',

    model: 'Task.model.Personnel',

    proxy: {
        type: 'ajax',
        url: 'https://localhost:44355/Reservation/GetAll'
    },
    autoLoad: true
});
