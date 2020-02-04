/**
 * This view is an example list of people.
 */
Ext.define('Task.view.main.List', {
    extend: 'Ext.grid.Panel',
    xtype: 'mainlist',

    requires: [
        'Task.store.Personnel'
    ],

    title: 'Rezerwacje',

    store: {
        type: 'personnel'
    },

    columns: [
        { text: 'Kod',  dataIndex: 'code',flex: 1 },
        { text: 'Data utworzenia',  dataIndex: 'createdAt',flex: 1 },
        { text: 'Cena', dataIndex: 'price', flex: 1 },
        { text: 'Waluta', dataIndex: 'currency', flex: 1 },
        { text: 'Data zameldowania', dataIndex: 'checkInDate', flex: 1 },
        { text: 'Data wymeldowania', dataIndex: 'checkOutDate', flex: 1 },
        { text: 'Prowizja', dataIndex: 'provision', flex: 1 },
        { text: 'Źródło', dataIndex: 'source', flex: 1 }
    ],

    listeners: {
        select: 'onItemSelected'
    }
});
