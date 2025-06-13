using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200043D RID: 1085
	public class SupplierLocationConfiguration : MonoBehaviour
	{
		// Token: 0x06005E3E RID: 24126 RVA: 0x001B5CE4 File Offset: 0x001B3EE4
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocationConfiguration()
		{
			Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr);
			SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, "SupplierID");
			SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675411);
			SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675412);
			SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675413);
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x001B5D64 File Offset: 0x001B3F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199157, RefRangeEnd = 199158, XrefRangeStart = 199154, XrefRangeEnd = 199157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x001B5D98 File Offset: 0x001B3F98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199161, RefRangeEnd = 199164, XrefRangeStart = 199158, XrefRangeEnd = 199161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x001B5DCC File Offset: 0x001B3FCC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocationConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x0002C34B File Offset: 0x0002A54B
		public SupplierLocationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06005E43 RID: 24131 RVA: 0x001B5E08 File Offset: 0x001B4008
		// (set) Token: 0x06005E44 RID: 24132 RVA: 0x0002C354 File Offset: 0x0002A554
		public unsafe string SupplierID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400407A RID: 16506
		private static readonly IntPtr NativeFieldInfoPtr_SupplierID;

		// Token: 0x0400407B RID: 16507
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x0400407C RID: 16508
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x0400407D RID: 16509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
