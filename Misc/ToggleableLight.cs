using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000799 RID: 1945
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x0600B87F RID: 47231 RVA: 0x002E1854 File Offset: 0x002DFA54
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableLight()
		{
			Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ToggleableLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr);
			ToggleableLight.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "isOn");
			ToggleableLight.NativeFieldInfoPtr_lightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSources");
			ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSurfacesMeshes");
			ToggleableLight.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "MaterialIndex");
			ToggleableLight.NativeFieldInfoPtr_lightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOnMat");
			ToggleableLight.NativeFieldInfoPtr_lightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOffMat");
			ToggleableLight.NativeFieldInfoPtr_constructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "constructable");
			ToggleableLight.NativeFieldInfoPtr_lightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightsApplied");
			ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686159);
			ToggleableLight.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686160);
			ToggleableLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686161);
			ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686162);
			ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686163);
			ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686164);
			ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100686165);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x002E19B0 File Offset: 0x002DFBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315687, XrefRangeEnd = 315691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x002E19EC File Offset: 0x002DFBEC
		[CallerCount(0)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x002E1A20 File Offset: 0x002DFC20
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x002E1A5C File Offset: 0x002DFC5C
		[CallerCount(0)]
		public unsafe void TurnOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x002E1A90 File Offset: 0x002DFC90
		[CallerCount(0)]
		public unsafe void TurnOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x002E1AC4 File Offset: 0x002DFCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315691, XrefRangeEnd = 315704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLights(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x002E1B10 File Offset: 0x002DFD10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x0005A1CE File Offset: 0x000583CE
		public ToggleableLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600B888 RID: 47240 RVA: 0x002E1B4C File Offset: 0x002DFD4C
		// (set) Token: 0x0600B889 RID: 47241 RVA: 0x0005A1D7 File Offset: 0x000583D7
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600B88A RID: 47242 RVA: 0x002E1B74 File Offset: 0x002DFD74
		// (set) Token: 0x0600B88B RID: 47243 RVA: 0x0005A1F2 File Offset: 0x000583F2
		public unsafe Il2CppReferenceArray<OptimizedLight> lightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600B88C RID: 47244 RVA: 0x002E1BA4 File Offset: 0x002DFDA4
		// (set) Token: 0x0600B88D RID: 47245 RVA: 0x0005A211 File Offset: 0x00058411
		public unsafe Il2CppReferenceArray<MeshRenderer> lightSurfacesMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600B88E RID: 47246 RVA: 0x002E1BD4 File Offset: 0x002DFDD4
		// (set) Token: 0x0600B88F RID: 47247 RVA: 0x0005A230 File Offset: 0x00058430
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600B890 RID: 47248 RVA: 0x002E1BFC File Offset: 0x002DFDFC
		// (set) Token: 0x0600B891 RID: 47249 RVA: 0x0005A24B File Offset: 0x0005844B
		public unsafe Material lightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600B892 RID: 47250 RVA: 0x002E1C2C File Offset: 0x002DFE2C
		// (set) Token: 0x0600B893 RID: 47251 RVA: 0x0005A26A File Offset: 0x0005846A
		public unsafe Material lightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600B894 RID: 47252 RVA: 0x002E1C5C File Offset: 0x002DFE5C
		// (set) Token: 0x0600B895 RID: 47253 RVA: 0x0005A289 File Offset: 0x00058489
		public unsafe Constructable_GridBased constructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_constructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_constructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600B896 RID: 47254 RVA: 0x002E1C8C File Offset: 0x002DFE8C
		// (set) Token: 0x0600B897 RID: 47255 RVA: 0x0005A2A8 File Offset: 0x000584A8
		public unsafe bool lightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightsApplied)) = value;
			}
		}

		// Token: 0x04007C83 RID: 31875
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x04007C84 RID: 31876
		private static readonly IntPtr NativeFieldInfoPtr_lightSources;

		// Token: 0x04007C85 RID: 31877
		private static readonly IntPtr NativeFieldInfoPtr_lightSurfacesMeshes;

		// Token: 0x04007C86 RID: 31878
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x04007C87 RID: 31879
		private static readonly IntPtr NativeFieldInfoPtr_lightOnMat;

		// Token: 0x04007C88 RID: 31880
		private static readonly IntPtr NativeFieldInfoPtr_lightOffMat;

		// Token: 0x04007C89 RID: 31881
		private static readonly IntPtr NativeFieldInfoPtr_constructable;

		// Token: 0x04007C8A RID: 31882
		private static readonly IntPtr NativeFieldInfoPtr_lightsApplied;

		// Token: 0x04007C8B RID: 31883
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007C8C RID: 31884
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04007C8D RID: 31885
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007C8E RID: 31886
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_0;

		// Token: 0x04007C8F RID: 31887
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_0;

		// Token: 0x04007C90 RID: 31888
		private static readonly IntPtr NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04007C91 RID: 31889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
