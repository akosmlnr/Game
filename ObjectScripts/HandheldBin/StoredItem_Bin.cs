using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x0200078C RID: 1932
	public class StoredItem_Bin : StoredItem
	{
		// Token: 0x0600B77A RID: 46970 RVA: 0x002DE910 File Offset: 0x002DCB10
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_Bin()
		{
			Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.HandheldBin", "StoredItem_Bin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr);
			StoredItem_Bin.NativeFieldInfoPtr_bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr, "bin");
			StoredItem_Bin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr, 100686069);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x002DE968 File Offset: 0x002DCB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_Bin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Bin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x0005989C File Offset: 0x00057A9C
		public StoredItem_Bin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600B77D RID: 46973 RVA: 0x002DE9A4 File Offset: 0x002DCBA4
		// (set) Token: 0x0600B77E RID: 46974 RVA: 0x000598A5 File Offset: 0x00057AA5
		public unsafe HandheldBin_Functional bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Bin.NativeFieldInfoPtr_bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandheldBin_Functional>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Bin.NativeFieldInfoPtr_bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BE7 RID: 31719
		private static readonly IntPtr NativeFieldInfoPtr_bin;

		// Token: 0x04007BE8 RID: 31720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
