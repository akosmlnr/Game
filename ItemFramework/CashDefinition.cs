using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EF RID: 1519
	[Serializable]
	public class CashDefinition : StorableItemDefinition
	{
		// Token: 0x06008511 RID: 34065 RVA: 0x00238790 File Offset: 0x00236990
		// Note: this type is marked as 'beforefieldinit'.
		static CashDefinition()
		{
			Il2CppClassPointerStore<CashDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "CashDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashDefinition>.NativeClassPtr);
			CashDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashDefinition>.NativeClassPtr, 100680048);
			CashDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashDefinition>.NativeClassPtr, 100680049);
		}

		// Token: 0x06008512 RID: 34066 RVA: 0x002387E8 File Offset: 0x002369E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250736, XrefRangeEnd = 250740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008513 RID: 34067 RVA: 0x00238840 File Offset: 0x00236A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x0003EFF4 File Offset: 0x0003D1F4
		public CashDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005A97 RID: 23191
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005A98 RID: 23192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
