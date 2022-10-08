export default {
    namespaced: true,
    state: {
    },
    getters: {
        isFirstUnlocked : function (state: any) {
            return state.length > 1
        },
        isSecondUnlocked : function (state: any) {
            return state.length > 3
        },
        isThirdUnlocked : function (state: any) {
            return state.length > 5
        },
        isFourthUnlocked : function (state: any) {
            return state.length > 7
        },
        isFithtUnlocked : function (state: any) {
            return state.length > 10
        },
    },
    mutations: {
        UPDATE_ACHIEVEMENT(state : any, payload : number) {
            state[payload] = true
        }
    },
    actions : {
        unlockAchievement(context : any, payload : number) {
            context.commit('UPDATE_ACHIEVEMENT', payload)
        }
    }
}