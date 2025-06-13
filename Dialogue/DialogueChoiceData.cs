using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000468 RID: 1128
	[System.Serializable]
	public class DialogueChoiceData : Il2CppSystem.Object
	{
		// Token: 0x0600615F RID: 24927 RVA: 0x001C0D90 File Offset: 0x001BEF90
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceData()
		{
			Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChoiceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr);
			DialogueChoiceData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "Guid");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceText");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceLabel");
			DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, 100675815);
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x001C0E10 File Offset: 0x001BF010
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x0002DADC File Offset: 0x0002BCDC
		public DialogueChoiceData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06006162 RID: 24930 RVA: 0x001C0E4C File Offset: 0x001BF04C
		// (set) Token: 0x06006163 RID: 24931 RVA: 0x0002DAE5 File Offset: 0x0002BCE5
		public unsafe string Guid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06006164 RID: 24932 RVA: 0x001C0E74 File Offset: 0x001BF074
		// (set) Token: 0x06006165 RID: 24933 RVA: 0x0002DB04 File Offset: 0x0002BD04
		public unsafe string ChoiceText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x001C0E9C File Offset: 0x001BF09C
		// (set) Token: 0x06006167 RID: 24935 RVA: 0x0002DB23 File Offset: 0x0002BD23
		public unsafe string ChoiceLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004296 RID: 17046
		private static readonly System.IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004297 RID: 17047
		private static readonly System.IntPtr NativeFieldInfoPtr_ChoiceText;

		// Token: 0x04004298 RID: 17048
		private static readonly System.IntPtr NativeFieldInfoPtr_ChoiceLabel;

		// Token: 0x04004299 RID: 17049
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
