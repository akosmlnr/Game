using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200073B RID: 1851
	public class ItemUI_WateringCan : ItemUI
	{
		// Token: 0x0600A5C2 RID: 42434 RVA: 0x0029BD60 File Offset: 0x00299F60
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_WateringCan()
		{
			Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_WateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr);
			ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, "wcInstance");
			ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, "AmountLabel");
			ItemUI_WateringCan.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683679);
			ItemUI_WateringCan.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683680);
			ItemUI_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683681);
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x0029BDF4 File Offset: 0x00299FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290243, XrefRangeEnd = 290249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_WateringCan.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x0029BE44 File Offset: 0x0029A044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290249, XrefRangeEnd = 290264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_WateringCan.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x0029BE80 File Offset: 0x0029A080
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_WateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x000515DF File Offset: 0x0004F7DF
		public ItemUI_WateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600A5C7 RID: 42439 RVA: 0x0029BEBC File Offset: 0x0029A0BC
		// (set) Token: 0x0600A5C8 RID: 42440 RVA: 0x000515E8 File Offset: 0x0004F7E8
		public unsafe WateringCanInstance wcInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600A5C9 RID: 42441 RVA: 0x0029BEEC File Offset: 0x0029A0EC
		// (set) Token: 0x0600A5CA RID: 42442 RVA: 0x00051607 File Offset: 0x0004F807
		public unsafe Text AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F34 RID: 28468
		private static readonly IntPtr NativeFieldInfoPtr_wcInstance;

		// Token: 0x04006F35 RID: 28469
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04006F36 RID: 28470
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006F37 RID: 28471
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006F38 RID: 28472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
