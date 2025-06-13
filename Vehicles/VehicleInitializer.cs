using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000510 RID: 1296
	public class VehicleInitializer : NetworkBehaviour
	{
		// Token: 0x06007147 RID: 28999 RVA: 0x001F5BAC File Offset: 0x001F3DAC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleInitializer()
		{
			Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr);
			VehicleInitializer.NativeFieldInfoPtr_InitialParkingLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, "InitialParkingLot");
			VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted");
			VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted");
			VehicleInitializer.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100677686);
			VehicleInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100677687);
			VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100677688);
			VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100677689);
			VehicleInitializer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100677690);
			VehicleInitializer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100677691);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x001F5C90 File Offset: 0x001F3E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224827, XrefRangeEnd = 224840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x001F5CCC File Offset: 0x001F3ECC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x001F5D08 File Offset: 0x001F3F08
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x001F5D44 File Offset: 0x001F3F44
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x001F5D80 File Offset: 0x001F3F80
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x001F5DBC File Offset: 0x001F3FBC
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00035644 File Offset: 0x00033844
		public VehicleInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600714F RID: 29007 RVA: 0x001F5DF8 File Offset: 0x001F3FF8
		// (set) Token: 0x06007150 RID: 29008 RVA: 0x0003564D File Offset: 0x0003384D
		public unsafe ParkingLot InitialParkingLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_InitialParkingLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_InitialParkingLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x001F5E28 File Offset: 0x001F4028
		// (set) Token: 0x06007152 RID: 29010 RVA: 0x0003566C File Offset: 0x0003386C
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x001F5E50 File Offset: 0x001F4050
		// (set) Token: 0x06007154 RID: 29012 RVA: 0x00035687 File Offset: 0x00033887
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004D74 RID: 19828
		private static readonly IntPtr NativeFieldInfoPtr_InitialParkingLot;

		// Token: 0x04004D75 RID: 19829
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004D76 RID: 19830
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004D77 RID: 19831
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004D78 RID: 19832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D79 RID: 19833
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004D7A RID: 19834
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004D7B RID: 19835
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004D7C RID: 19836
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
