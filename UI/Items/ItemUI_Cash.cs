using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200073A RID: 1850
	public class ItemUI_Cash : ItemUI
	{
		// Token: 0x0600A5B8 RID: 42424 RVA: 0x0029BB50 File Offset: 0x00299D50
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_Cash()
		{
			Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr);
			ItemUI_Cash.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "cashInstance");
			ItemUI_Cash.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "AmountLabel");
			ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683675);
			ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683676);
			ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683677);
			ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683678);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x0029BBF8 File Offset: 0x00299DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290233, XrefRangeEnd = 290239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x0029BC48 File Offset: 0x00299E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290239, XrefRangeEnd = 290241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x0029BC84 File Offset: 0x00299E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290241, XrefRangeEnd = 290243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x0029BCC4 File Offset: 0x00299EC4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x00051598 File Offset: 0x0004F798
		public ItemUI_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600A5BE RID: 42430 RVA: 0x0029BD00 File Offset: 0x00299F00
		// (set) Token: 0x0600A5BF RID: 42431 RVA: 0x000515A1 File Offset: 0x0004F7A1
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x0029BD30 File Offset: 0x00299F30
		// (set) Token: 0x0600A5C1 RID: 42433 RVA: 0x000515C0 File Offset: 0x0004F7C0
		public unsafe TextMeshProUGUI AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F2E RID: 28462
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x04006F2F RID: 28463
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04006F30 RID: 28464
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006F31 RID: 28465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006F32 RID: 28466
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0;

		// Token: 0x04006F33 RID: 28467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
