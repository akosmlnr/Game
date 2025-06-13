using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D5 RID: 725
	[System.Serializable]
	public class TextResponseData : Il2CppSystem.Object
	{
		// Token: 0x0600332A RID: 13098 RVA: 0x0011645C File Offset: 0x0011465C
		// Note: this type is marked as 'beforefieldinit'.
		static TextResponseData()
		{
			Il2CppClassPointerStore<TextResponseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextResponseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr);
			TextResponseData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Text");
			TextResponseData.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Label");
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100669097);
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100669098);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x001164DC File Offset: 0x001146DC
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 114146, RefRangeEnd = 114197, XrefRangeStart = 114146, XrefRangeEnd = 114197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData(string text, string label) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0011653C File Offset: 0x0011473C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137240, RefRangeEnd = 137241, XrefRangeStart = 137232, XrefRangeEnd = 137240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0001B278 File Offset: 0x00019478
		public TextResponseData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x00116578 File Offset: 0x00114778
		// (set) Token: 0x0600332F RID: 13103 RVA: 0x0001B281 File Offset: 0x00019481
		public unsafe string Text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x001165A0 File Offset: 0x001147A0
		// (set) Token: 0x06003331 RID: 13105 RVA: 0x0001B2A0 File Offset: 0x000194A0
		public unsafe string Label
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002137 RID: 8503
		private static readonly System.IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002138 RID: 8504
		private static readonly System.IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04002139 RID: 8505
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400213A RID: 8506
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
