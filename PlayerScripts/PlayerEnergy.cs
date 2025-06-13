using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000406 RID: 1030
	public class PlayerEnergy : MonoBehaviour
	{
		// Token: 0x0600523C RID: 21052 RVA: 0x00189830 File Offset: 0x00187A30
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEnergy()
		{
			Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerEnergy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr);
			PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "CRITICAL_THRESHOLD");
			PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "MAX_ENERGY");
			PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "SPRINT_DRAIN_MULTIPLIER");
			PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "<CurrentEnergy>k__BackingField");
			PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "<EnergyDrinksConsumed>k__BackingField");
			PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "DEBUG_DISABLE_ENERGY");
			PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "EnergyDuration_Hours");
			PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "EnergyRechargeTime_Hours");
			PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "onEnergyChanged");
			PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "onEnergyDepleted");
			PlayerEnergy.NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673702);
			PlayerEnergy.NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673703);
			PlayerEnergy.NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673704);
			PlayerEnergy.NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673705);
			PlayerEnergy.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673706);
			PlayerEnergy.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673707);
			PlayerEnergy.NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673708);
			PlayerEnergy.NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673709);
			PlayerEnergy.NativeMethodInfoPtr_RestoreEnergy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673710);
			PlayerEnergy.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673711);
			PlayerEnergy.NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673712);
			PlayerEnergy.NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673713);
			PlayerEnergy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673714);
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x00189A2C File Offset: 0x00187C2C
		// (set) Token: 0x0600523E RID: 21054 RVA: 0x00189A68 File Offset: 0x00187C68
		public unsafe float CurrentEnergy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x00189AA8 File Offset: 0x00187CA8
		// (set) Token: 0x06005240 RID: 21056 RVA: 0x00189AE4 File Offset: 0x00187CE4
		public unsafe int EnergyDrinksConsumed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00189B24 File Offset: 0x00187D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179557, XrefRangeEnd = 179595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergy.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00189B60 File Offset: 0x00187D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179595, XrefRangeEnd = 179610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00189B94 File Offset: 0x00187D94
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEnergy(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00189BD4 File Offset: 0x00187DD4
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnergy(float newEnergy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newEnergy;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00189C14 File Offset: 0x00187E14
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_RestoreEnergy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00189C48 File Offset: 0x00187E48
		[CallerCount(0)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00189C7C File Offset: 0x00187E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179610, RefRangeEnd = 179611, XrefRangeStart = 179610, XrefRangeEnd = 179610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementEnergyDrinks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00189CB0 File Offset: 0x00187EB0
		[CallerCount(0)]
		public unsafe void ResetEnergyDrinks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00189CE4 File Offset: 0x00187EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179611, XrefRangeEnd = 179612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEnergy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00026E7A File Offset: 0x0002507A
		public PlayerEnergy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x00189D20 File Offset: 0x00187F20
		// (set) Token: 0x0600524C RID: 21068 RVA: 0x00026E83 File Offset: 0x00025083
		public unsafe static float CRITICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600524D RID: 21069 RVA: 0x00189D3C File Offset: 0x00187F3C
		// (set) Token: 0x0600524E RID: 21070 RVA: 0x00026E91 File Offset: 0x00025091
		public unsafe static float MAX_ENERGY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY, (void*)(&value));
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x0600524F RID: 21071 RVA: 0x00189D58 File Offset: 0x00187F58
		// (set) Token: 0x06005250 RID: 21072 RVA: 0x00026E9F File Offset: 0x0002509F
		public unsafe static float SPRINT_DRAIN_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x00189D74 File Offset: 0x00187F74
		// (set) Token: 0x06005252 RID: 21074 RVA: 0x00026EAD File Offset: 0x000250AD
		public unsafe float _CurrentEnergy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField)) = value;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x00189D9C File Offset: 0x00187F9C
		// (set) Token: 0x06005254 RID: 21076 RVA: 0x00026EC8 File Offset: 0x000250C8
		public unsafe int _EnergyDrinksConsumed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x00189DC4 File Offset: 0x00187FC4
		// (set) Token: 0x06005256 RID: 21078 RVA: 0x00026EE3 File Offset: 0x000250E3
		public unsafe bool DEBUG_DISABLE_ENERGY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY)) = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x00189DEC File Offset: 0x00187FEC
		// (set) Token: 0x06005258 RID: 21080 RVA: 0x00026EFE File Offset: 0x000250FE
		public unsafe float EnergyDuration_Hours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours)) = value;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06005259 RID: 21081 RVA: 0x00189E14 File Offset: 0x00188014
		// (set) Token: 0x0600525A RID: 21082 RVA: 0x00026F19 File Offset: 0x00025119
		public unsafe float EnergyRechargeTime_Hours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours)) = value;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x00189E3C File Offset: 0x0018803C
		// (set) Token: 0x0600525C RID: 21084 RVA: 0x00026F34 File Offset: 0x00025134
		public unsafe UnityEvent onEnergyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x00189E6C File Offset: 0x0018806C
		// (set) Token: 0x0600525E RID: 21086 RVA: 0x00026F53 File Offset: 0x00025153
		public unsafe UnityEvent onEnergyDepleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeFieldInfoPtr_CRITICAL_THRESHOLD;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ENERGY;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEnergy_k__BackingField;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeFieldInfoPtr_EnergyDuration_Hours;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeFieldInfoPtr_EnergyRechargeTime_Hours;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeFieldInfoPtr_onEnergyChanged;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeFieldInfoPtr_onEnergyDepleted;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr_RestoreEnergy_Public_Void_0;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0;

		// Token: 0x040037DF RID: 14303
		private static readonly IntPtr NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0;

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
