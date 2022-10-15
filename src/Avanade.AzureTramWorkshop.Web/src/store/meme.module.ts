export default {
    namespaced: true,
    state: {
        config: [1, 3, 5, 7, 10],
        filePrefix: 'Krakow',
        items: []
    },
    getters: {
        getFileName: (state: any) => (index: number) => {
            return `${state.filePrefix}_${index}.jpg`;
        },
        isIndexUnlocked: (state: any) => (index: number) => {
            return state.items.length > state.config[index]
        }
    },
    mutations: {
        UPDATE_ACHIEVEMENT(state : any, payload : number) {
            if (!state.items.includes(payload))
                state.items.push(payload);
        }
    },
    actions : {
        unlockAchievement(context : any, payload : number) {
            context.commit('UPDATE_ACHIEVEMENT', payload)
        }
    }
}