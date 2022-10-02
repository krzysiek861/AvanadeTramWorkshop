import { createStore } from 'vuex'
import speedModule from './speed.module'
import temperatureModule from './temperature.module'
import weightModule from './weight.module'

export default createStore({
  modules: {
    speed: speedModule,
    temperature: temperatureModule,
    weight: weightModule,
  }
})