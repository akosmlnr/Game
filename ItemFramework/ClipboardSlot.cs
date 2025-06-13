using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F5 RID: 1525
	public class ClipboardSlot : HotbarSlot
	{
		// Token: 0x0600854D RID: 34125 RVA: 0x00239348 File Offset: 0x00237548
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardSlot()
		{
			Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ClipboardSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr);
			ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100680070);
			ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100680071);
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x002393A0 File Offset: 0x002375A0
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600854F RID: 34127 RVA: 0x002393EC File Offset: 0x002375EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250812, RefRangeEnd = 250814, XrefRangeStart = 250811, XrefRangeEnd = 250812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008550 RID: 34128 RVA: 0x0003F18C File Offset: 0x0003D38C
		public ClipboardSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005ABA RID: 23226
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005ABB RID: 23227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
