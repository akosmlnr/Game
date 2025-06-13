using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005EC RID: 1516
	public class LoadingDock : Constructable_GridBased
	{
		// Token: 0x06008439 RID: 33849 RVA: 0x00235604 File Offset: 0x00233804
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingDock()
		{
			Il2CppClassPointerStore<LoadingDock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "LoadingDock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr);
			LoadingDock.NativeFieldInfoPtr_vehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "vehicleDetector");
			LoadingDock.NativeFieldInfoPtr_redLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "redLightMeshes");
			LoadingDock.NativeFieldInfoPtr_greenLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "greenLightMeshes");
			LoadingDock.NativeFieldInfoPtr_sideWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "sideWalls");
			LoadingDock.NativeFieldInfoPtr_gateAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "gateAnim");
			LoadingDock.NativeFieldInfoPtr_reservationBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "reservationBlocker");
			LoadingDock.NativeFieldInfoPtr_vehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "vehiclePosition");
			LoadingDock.NativeFieldInfoPtr_redLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "redLightMat_On");
			LoadingDock.NativeFieldInfoPtr_redLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "redLightMat_Off");
			LoadingDock.NativeFieldInfoPtr_greenLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "greenLightMat_On");
			LoadingDock.NativeFieldInfoPtr_greenLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "greenLightMat_Off");
			LoadingDock.NativeFieldInfoPtr_wallsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "wallsOpen");
			LoadingDock.NativeFieldInfoPtr_currentOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "currentOccupant");
			LoadingDock.NativeFieldInfoPtr__reservant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<reservant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted");
			LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted");
			LoadingDock.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679938);
			LoadingDock.NativeMethodInfoPtr_get_reservant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679939);
			LoadingDock.NativeMethodInfoPtr_set_reservant_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679940);
			LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679941);
			LoadingDock.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679942);
			LoadingDock.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679943);
			LoadingDock.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679944);
			LoadingDock.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679945);
			LoadingDock.NativeMethodInfoPtr_SetReservant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679946);
			LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679947);
			LoadingDock.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679948);
			LoadingDock.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679949);
			LoadingDock.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679950);
			LoadingDock.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679951);
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x0600843A RID: 33850 RVA: 0x0023588C File Offset: 0x00233A8C
		public unsafe bool isOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249563, XrefRangeEnd = 249564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x002358C8 File Offset: 0x00233AC8
		// (set) Token: 0x0600843C RID: 33852 RVA: 0x00235908 File Offset: 0x00233B08
		public unsafe LandVehicle reservant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_reservant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249564, XrefRangeEnd = 249565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_reservant_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x0023594C File Offset: 0x00233B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249565, XrefRangeEnd = 249568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x00235980 File Offset: 0x00233B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249568, XrefRangeEnd = 249579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x002359BC File Offset: 0x00233BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249579, XrefRangeEnd = 249610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x002359F8 File Offset: 0x00233BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249610, XrefRangeEnd = 249618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x00235A5C File Offset: 0x00233C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249618, XrefRangeEnd = 249626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00235AA8 File Offset: 0x00233CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249626, XrefRangeEnd = 249663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReservant(LandVehicle _res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_res);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetReservant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x00235AEC File Offset: 0x00233CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingDock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x00235B28 File Offset: 0x00233D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249663, XrefRangeEnd = 249664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x00235B64 File Offset: 0x00233D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249664, XrefRangeEnd = 249665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x00235BA0 File Offset: 0x00233DA0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x00235BDC File Offset: 0x00233DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x0003E9B2 File Offset: 0x0003CBB2
		public LoadingDock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x06008449 RID: 33865 RVA: 0x00235C18 File Offset: 0x00233E18
		// (set) Token: 0x0600844A RID: 33866 RVA: 0x0003E9BB File Offset: 0x0003CBBB
		public unsafe VehicleDetector vehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x00235C48 File Offset: 0x00233E48
		// (set) Token: 0x0600844C RID: 33868 RVA: 0x0003E9DA File Offset: 0x0003CBDA
		public unsafe Il2CppReferenceArray<MeshRenderer> redLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x0600844D RID: 33869 RVA: 0x00235C78 File Offset: 0x00233E78
		// (set) Token: 0x0600844E RID: 33870 RVA: 0x0003E9F9 File Offset: 0x0003CBF9
		public unsafe Il2CppReferenceArray<MeshRenderer> greenLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x0600844F RID: 33871 RVA: 0x00235CA8 File Offset: 0x00233EA8
		// (set) Token: 0x06008450 RID: 33872 RVA: 0x0003EA18 File Offset: 0x0003CC18
		public unsafe Il2CppReferenceArray<Transform> sideWalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_sideWalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_sideWalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x06008451 RID: 33873 RVA: 0x00235CD8 File Offset: 0x00233ED8
		// (set) Token: 0x06008452 RID: 33874 RVA: 0x0003EA37 File Offset: 0x0003CC37
		public unsafe Animation gateAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_gateAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_gateAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x06008453 RID: 33875 RVA: 0x00235D08 File Offset: 0x00233F08
		// (set) Token: 0x06008454 RID: 33876 RVA: 0x0003EA56 File Offset: 0x0003CC56
		public unsafe Collider reservationBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_reservationBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_reservationBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x06008455 RID: 33877 RVA: 0x00235D38 File Offset: 0x00233F38
		// (set) Token: 0x06008456 RID: 33878 RVA: 0x0003EA75 File Offset: 0x0003CC75
		public unsafe Transform vehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x06008457 RID: 33879 RVA: 0x00235D68 File Offset: 0x00233F68
		// (set) Token: 0x06008458 RID: 33880 RVA: 0x0003EA94 File Offset: 0x0003CC94
		public unsafe Material redLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x06008459 RID: 33881 RVA: 0x00235D98 File Offset: 0x00233F98
		// (set) Token: 0x0600845A RID: 33882 RVA: 0x0003EAB3 File Offset: 0x0003CCB3
		public unsafe Material redLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x0600845B RID: 33883 RVA: 0x00235DC8 File Offset: 0x00233FC8
		// (set) Token: 0x0600845C RID: 33884 RVA: 0x0003EAD2 File Offset: 0x0003CCD2
		public unsafe Material greenLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x0600845D RID: 33885 RVA: 0x00235DF8 File Offset: 0x00233FF8
		// (set) Token: 0x0600845E RID: 33886 RVA: 0x0003EAF1 File Offset: 0x0003CCF1
		public unsafe Material greenLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600845F RID: 33887 RVA: 0x00235E28 File Offset: 0x00234028
		// (set) Token: 0x06008460 RID: 33888 RVA: 0x0003EB10 File Offset: 0x0003CD10
		public unsafe bool wallsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_wallsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_wallsOpen)) = value;
			}
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x06008461 RID: 33889 RVA: 0x00235E50 File Offset: 0x00234050
		// (set) Token: 0x06008462 RID: 33890 RVA: 0x0003EB2B File Offset: 0x0003CD2B
		public unsafe LandVehicle currentOccupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_currentOccupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_currentOccupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x06008463 RID: 33891 RVA: 0x00235E80 File Offset: 0x00234080
		// (set) Token: 0x06008464 RID: 33892 RVA: 0x0003EB4A File Offset: 0x0003CD4A
		public unsafe LandVehicle _reservant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__reservant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__reservant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x00235EB0 File Offset: 0x002340B0
		// (set) Token: 0x06008466 RID: 33894 RVA: 0x0003EB69 File Offset: 0x0003CD69
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x00235ED8 File Offset: 0x002340D8
		// (set) Token: 0x06008468 RID: 33896 RVA: 0x0003EB84 File Offset: 0x0003CD84
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040059FA RID: 23034
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDetector;

		// Token: 0x040059FB RID: 23035
		private static readonly IntPtr NativeFieldInfoPtr_redLightMeshes;

		// Token: 0x040059FC RID: 23036
		private static readonly IntPtr NativeFieldInfoPtr_greenLightMeshes;

		// Token: 0x040059FD RID: 23037
		private static readonly IntPtr NativeFieldInfoPtr_sideWalls;

		// Token: 0x040059FE RID: 23038
		private static readonly IntPtr NativeFieldInfoPtr_gateAnim;

		// Token: 0x040059FF RID: 23039
		private static readonly IntPtr NativeFieldInfoPtr_reservationBlocker;

		// Token: 0x04005A00 RID: 23040
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePosition;

		// Token: 0x04005A01 RID: 23041
		private static readonly IntPtr NativeFieldInfoPtr_redLightMat_On;

		// Token: 0x04005A02 RID: 23042
		private static readonly IntPtr NativeFieldInfoPtr_redLightMat_Off;

		// Token: 0x04005A03 RID: 23043
		private static readonly IntPtr NativeFieldInfoPtr_greenLightMat_On;

		// Token: 0x04005A04 RID: 23044
		private static readonly IntPtr NativeFieldInfoPtr_greenLightMat_Off;

		// Token: 0x04005A05 RID: 23045
		private static readonly IntPtr NativeFieldInfoPtr_wallsOpen;

		// Token: 0x04005A06 RID: 23046
		private static readonly IntPtr NativeFieldInfoPtr_currentOccupant;

		// Token: 0x04005A07 RID: 23047
		private static readonly IntPtr NativeFieldInfoPtr__reservant_k__BackingField;

		// Token: 0x04005A08 RID: 23048
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005A09 RID: 23049
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005A0A RID: 23050
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04005A0B RID: 23051
		private static readonly IntPtr NativeMethodInfoPtr_get_reservant_Public_get_LandVehicle_0;

		// Token: 0x04005A0C RID: 23052
		private static readonly IntPtr NativeMethodInfoPtr_set_reservant_Protected_set_Void_LandVehicle_0;

		// Token: 0x04005A0D RID: 23053
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005A0E RID: 23054
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005A0F RID: 23055
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005A10 RID: 23056
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04005A11 RID: 23057
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005A12 RID: 23058
		private static readonly IntPtr NativeMethodInfoPtr_SetReservant_Public_Void_LandVehicle_0;

		// Token: 0x04005A13 RID: 23059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005A14 RID: 23060
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005A15 RID: 23061
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005A16 RID: 23062
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005A17 RID: 23063
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
