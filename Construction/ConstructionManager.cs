using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Construction;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Construction
{
	// Token: 0x020004A3 RID: 1187
	public class ConstructionManager : Singleton<ConstructionManager>
	{
		// Token: 0x060065D9 RID: 26073 RVA: 0x001CF06C File Offset: 0x001CD26C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionManager()
		{
			Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction", "ConstructionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr);
			ConstructionManager.NativeFieldInfoPtr_networkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "networkObject");
			ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<constructionModeEnabled>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructionModeEnabled");
			ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructionModeDisabled");
			ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<isDeployingConstructable>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_constructHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "constructHandler");
			ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<isMovingConstructable>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onNewConstructableBuilt");
			ConstructionManager.NativeFieldInfoPtr_onConstructableMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructableMoved");
			ConstructionManager.NativeFieldInfoPtr_currentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "currentProperty");
			ConstructionManager.NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676296);
			ConstructionManager.NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676297);
			ConstructionManager.NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676298);
			ConstructionManager.NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676299);
			ConstructionManager.NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676300);
			ConstructionManager.NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676301);
			ConstructionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676302);
			ConstructionManager.NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676303);
			ConstructionManager.NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676304);
			ConstructionManager.NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676305);
			ConstructionManager.NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676306);
			ConstructionManager.NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676307);
			ConstructionManager.NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676308);
			ConstructionManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676309);
			ConstructionManager.NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676310);
			ConstructionManager.NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676311);
			ConstructionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100676312);
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x060065DA RID: 26074 RVA: 0x001CF2B8 File Offset: 0x001CD4B8
		// (set) Token: 0x060065DB RID: 26075 RVA: 0x001CF2F4 File Offset: 0x001CD4F4
		public unsafe bool constructionModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x060065DC RID: 26076 RVA: 0x001CF334 File Offset: 0x001CD534
		// (set) Token: 0x060065DD RID: 26077 RVA: 0x001CF370 File Offset: 0x001CD570
		public unsafe bool isDeployingConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 53388, RefRangeEnd = 53391, XrefRangeStart = 53388, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x001CF3B0 File Offset: 0x001CD5B0
		// (set) Token: 0x060065DF RID: 26079 RVA: 0x001CF3EC File Offset: 0x001CD5EC
		public unsafe bool isMovingConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x001CF42C File Offset: 0x001CD62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208392, XrefRangeEnd = 208405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x001CF468 File Offset: 0x001CD668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208421, RefRangeEnd = 208422, XrefRangeStart = 208405, XrefRangeEnd = 208421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterConstructionMode(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x001CF4AC File Offset: 0x001CD6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208443, RefRangeEnd = 208444, XrefRangeStart = 208422, XrefRangeEnd = 208443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitConstructionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x001CF4E0 File Offset: 0x001CD6E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208467, RefRangeEnd = 208469, XrefRangeStart = 208444, XrefRangeEnd = 208467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x001CF524 File Offset: 0x001CD724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208473, RefRangeEnd = 208474, XrefRangeStart = 208469, XrefRangeEnd = 208473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopConstructableDeploy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x001CF558 File Offset: 0x001CD758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208495, RefRangeEnd = 208496, XrefRangeStart = 208474, XrefRangeEnd = 208495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveConstructable(Constructable_GridBased c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x001CF59C File Offset: 0x001CD79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208496, XrefRangeEnd = 208500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopMovingConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x001CF5D0 File Offset: 0x001CD7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208500, XrefRangeEnd = 208502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x001CF614 File Offset: 0x001CD814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208502, XrefRangeEnd = 208514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x001CF694 File Offset: 0x001CD894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208525, RefRangeEnd = 208526, XrefRangeStart = 208514, XrefRangeEnd = 208525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable CreateConstructable(string prefabID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x001CF6E4 File Offset: 0x001CD8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208526, XrefRangeEnd = 208529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x0002FEE8 File Offset: 0x0002E0E8
		public ConstructionManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x060065EC RID: 26092 RVA: 0x001CF720 File Offset: 0x001CD920
		// (set) Token: 0x060065ED RID: 26093 RVA: 0x0002FEF1 File Offset: 0x0002E0F1
		public unsafe NetworkObject networkObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_networkObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_networkObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x060065EE RID: 26094 RVA: 0x001CF750 File Offset: 0x001CD950
		// (set) Token: 0x060065EF RID: 26095 RVA: 0x0002FF10 File Offset: 0x0002E110
		public unsafe bool _constructionModeEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x060065F0 RID: 26096 RVA: 0x001CF778 File Offset: 0x001CD978
		// (set) Token: 0x060065F1 RID: 26097 RVA: 0x0002FF2B File Offset: 0x0002E12B
		public unsafe Il2CppSystem.Action onConstructionModeEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x060065F2 RID: 26098 RVA: 0x001CF7A8 File Offset: 0x001CD9A8
		// (set) Token: 0x060065F3 RID: 26099 RVA: 0x0002FF4A File Offset: 0x0002E14A
		public unsafe Il2CppSystem.Action onConstructionModeDisabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x001CF7D8 File Offset: 0x001CD9D8
		// (set) Token: 0x060065F5 RID: 26101 RVA: 0x0002FF69 File Offset: 0x0002E169
		public unsafe bool _isDeployingConstructable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x001CF800 File Offset: 0x001CDA00
		// (set) Token: 0x060065F7 RID: 26103 RVA: 0x0002FF84 File Offset: 0x0002E184
		public unsafe GameObject constructHandler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_constructHandler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_constructHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x060065F8 RID: 26104 RVA: 0x001CF830 File Offset: 0x001CDA30
		// (set) Token: 0x060065F9 RID: 26105 RVA: 0x0002FFA3 File Offset: 0x0002E1A3
		public unsafe bool _isMovingConstructable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x060065FA RID: 26106 RVA: 0x001CF858 File Offset: 0x001CDA58
		// (set) Token: 0x060065FB RID: 26107 RVA: 0x0002FFBE File Offset: 0x0002E1BE
		public unsafe ConstructionManager.ConstructableNotification onNewConstructableBuilt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.ConstructableNotification>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x001CF888 File Offset: 0x001CDA88
		// (set) Token: 0x060065FD RID: 26109 RVA: 0x0002FFDD File Offset: 0x0002E1DD
		public unsafe ConstructionManager.ConstructableNotification onConstructableMoved
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructableMoved);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.ConstructableNotification>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructableMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x001CF8B8 File Offset: 0x001CDAB8
		// (set) Token: 0x060065FF RID: 26111 RVA: 0x0002FFFC File Offset: 0x0002E1FC
		public unsafe Property currentProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_currentProperty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_currentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004582 RID: 17794
		private static readonly System.IntPtr NativeFieldInfoPtr_networkObject;

		// Token: 0x04004583 RID: 17795
		private static readonly System.IntPtr NativeFieldInfoPtr__constructionModeEnabled_k__BackingField;

		// Token: 0x04004584 RID: 17796
		private static readonly System.IntPtr NativeFieldInfoPtr_onConstructionModeEnabled;

		// Token: 0x04004585 RID: 17797
		private static readonly System.IntPtr NativeFieldInfoPtr_onConstructionModeDisabled;

		// Token: 0x04004586 RID: 17798
		private static readonly System.IntPtr NativeFieldInfoPtr__isDeployingConstructable_k__BackingField;

		// Token: 0x04004587 RID: 17799
		private static readonly System.IntPtr NativeFieldInfoPtr_constructHandler;

		// Token: 0x04004588 RID: 17800
		private static readonly System.IntPtr NativeFieldInfoPtr__isMovingConstructable_k__BackingField;

		// Token: 0x04004589 RID: 17801
		private static readonly System.IntPtr NativeFieldInfoPtr_onNewConstructableBuilt;

		// Token: 0x0400458A RID: 17802
		private static readonly System.IntPtr NativeFieldInfoPtr_onConstructableMoved;

		// Token: 0x0400458B RID: 17803
		private static readonly System.IntPtr NativeFieldInfoPtr_currentProperty;

		// Token: 0x0400458C RID: 17804
		private static readonly System.IntPtr NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0;

		// Token: 0x0400458D RID: 17805
		private static readonly System.IntPtr NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400458E RID: 17806
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0;

		// Token: 0x0400458F RID: 17807
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0;

		// Token: 0x04004590 RID: 17808
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0;

		// Token: 0x04004591 RID: 17809
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0;

		// Token: 0x04004592 RID: 17810
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004593 RID: 17811
		private static readonly System.IntPtr NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0;

		// Token: 0x04004594 RID: 17812
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0;

		// Token: 0x04004595 RID: 17813
		private static readonly System.IntPtr NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0;

		// Token: 0x04004596 RID: 17814
		private static readonly System.IntPtr NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0;

		// Token: 0x04004597 RID: 17815
		private static readonly System.IntPtr NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0;

		// Token: 0x04004598 RID: 17816
		private static readonly System.IntPtr NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0;

		// Token: 0x04004599 RID: 17817
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400459A RID: 17818
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0;

		// Token: 0x0400459B RID: 17819
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0;

		// Token: 0x0400459C RID: 17820
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A77 RID: 2679
		public class WorldIntersection : Il2CppSystem.Object
		{
			// Token: 0x0600D46B RID: 54379 RVA: 0x00332988 File Offset: 0x00330B88
			// Note: this type is marked as 'beforefieldinit'.
			static WorldIntersection()
			{
				Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "WorldIntersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr);
				ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, "footprint");
				ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, "tile");
				ConstructionManager.WorldIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, 100676313);
			}

			// Token: 0x0600D46C RID: 54380 RVA: 0x003329F0 File Offset: 0x00330BF0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorldIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.WorldIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D46D RID: 54381 RVA: 0x00067035 File Offset: 0x00065235
			public WorldIntersection(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B6 RID: 16822
			// (get) Token: 0x0600D46E RID: 54382 RVA: 0x00332A2C File Offset: 0x00330C2C
			// (set) Token: 0x0600D46F RID: 54383 RVA: 0x0006703E File Offset: 0x0006523E
			public unsafe FootprintTile footprint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B7 RID: 16823
			// (get) Token: 0x0600D470 RID: 54384 RVA: 0x00332A5C File Offset: 0x00330C5C
			// (set) Token: 0x0600D471 RID: 54385 RVA: 0x0006705D File Offset: 0x0006525D
			public unsafe Tile tile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F5D RID: 36701
			private static readonly System.IntPtr NativeFieldInfoPtr_footprint;

			// Token: 0x04008F5E RID: 36702
			private static readonly System.IntPtr NativeFieldInfoPtr_tile;

			// Token: 0x04008F5F RID: 36703
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A78 RID: 2680
		public sealed class ConstructableNotification : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600D472 RID: 54386 RVA: 0x00332A8C File Offset: 0x00330C8C
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructableNotification()
			{
				Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "ConstructableNotification");
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100676314);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100676315);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100676316);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100676317);
			}

			// Token: 0x0600D473 RID: 54387 RVA: 0x00332B00 File Offset: 0x00330D00
			[CallerCount(500)]
			[CachedScanResults(RefRangeStart = 85002, RefRangeEnd = 85502, XrefRangeStart = 85002, XrefRangeEnd = 85502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructableNotification(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D474 RID: 54388 RVA: 0x00332B5C File Offset: 0x00330D5C
			[CallerCount(0)]
			public unsafe void Invoke(Constructable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D475 RID: 54389 RVA: 0x00332BA0 File Offset: 0x00330DA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Constructable c, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600D476 RID: 54390 RVA: 0x00332C14 File Offset: 0x00330E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D477 RID: 54391 RVA: 0x0006707C File Offset: 0x0006527C
			public ConstructableNotification(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D478 RID: 54392 RVA: 0x00067085 File Offset: 0x00065285
			public static implicit operator ConstructionManager.ConstructableNotification(System.Action<Constructable> A_0)
			{
				return DelegateSupport.ConvertDelegate<ConstructionManager.ConstructableNotification>(A_0);
			}

			// Token: 0x0600D479 RID: 54393 RVA: 0x0006708D File Offset: 0x0006528D
			public static ConstructionManager.ConstructableNotification operator +(ConstructionManager.ConstructableNotification A_0, ConstructionManager.ConstructableNotification A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<ConstructionManager.ConstructableNotification>();
			}

			// Token: 0x0600D47A RID: 54394 RVA: 0x0006709B File Offset: 0x0006529B
			public static ConstructionManager.ConstructableNotification operator -(ConstructionManager.ConstructableNotification A_0, ConstructionManager.ConstructableNotification A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<ConstructionManager.ConstructableNotification>();
				}
				return result;
			}

			// Token: 0x04008F60 RID: 36704
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008F61 RID: 36705
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0;

			// Token: 0x04008F62 RID: 36706
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0;

			// Token: 0x04008F63 RID: 36707
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
