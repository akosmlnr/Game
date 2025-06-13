using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200053F RID: 1343
	public class TrashBag : TrashItem
	{
		// Token: 0x06007694 RID: 30356 RVA: 0x00206924 File Offset: 0x00204B24
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag()
		{
			Il2CppClassPointerStore<TrashBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag>.NativeClassPtr);
			TrashBag.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, "<Content>k__BackingField");
			TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100678291);
			TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100678292);
			TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100678293);
			TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100678294);
			TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100678295);
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x002069CC File Offset: 0x00204BCC
		// (set) Token: 0x06007696 RID: 30358 RVA: 0x00206A0C File Offset: 0x00204C0C
		public unsafe TrashContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45432, RefRangeEnd = 45433, XrefRangeStart = 45432, XrefRangeEnd = 45433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00206A50 File Offset: 0x00204C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231530, RefRangeEnd = 231531, XrefRangeStart = 231528, XrefRangeEnd = 231530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00206A94 File Offset: 0x00204C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231531, XrefRangeEnd = 231541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr2) : null;
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x00206AE0 File Offset: 0x00204CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231541, XrefRangeEnd = 231565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00038132 File Offset: 0x00036332
		public TrashBag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x0600769B RID: 30363 RVA: 0x00206B1C File Offset: 0x00204D1C
		// (set) Token: 0x0600769C RID: 30364 RVA: 0x0003813B File Offset: 0x0003633B
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050F8 RID: 20728
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x040050F9 RID: 20729
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x040050FA RID: 20730
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0;

		// Token: 0x040050FB RID: 20731
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0;

		// Token: 0x040050FC RID: 20732
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0;

		// Token: 0x040050FD RID: 20733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
