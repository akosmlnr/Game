using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D4 RID: 724
	[System.Serializable]
	public class TextMessageData : Il2CppSystem.Object
	{
		// Token: 0x0600331E RID: 13086 RVA: 0x00116260 File Offset: 0x00114460
		// Note: this type is marked as 'beforefieldinit'.
		static TextMessageData()
		{
			Il2CppClassPointerStore<TextMessageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextMessageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr);
			TextMessageData.NativeFieldInfoPtr_Sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Sender");
			TextMessageData.NativeFieldInfoPtr_MessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "MessageID");
			TextMessageData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Text");
			TextMessageData.NativeFieldInfoPtr_EndOfChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "EndOfChain");
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100669095);
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100669096);
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00116308 File Offset: 0x00114508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137225, RefRangeEnd = 137226, XrefRangeStart = 137223, XrefRangeEnd = 137225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData(int sender, int messageID, string text, bool endOfChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sender;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref messageID;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endOfChain;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00116380 File Offset: 0x00114580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137231, RefRangeEnd = 137232, XrefRangeStart = 137226, XrefRangeEnd = 137231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0001B1FF File Offset: 0x000193FF
		public TextMessageData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x001163BC File Offset: 0x001145BC
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x0001B208 File Offset: 0x00019408
		public unsafe int Sender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender)) = value;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x001163E4 File Offset: 0x001145E4
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x0001B223 File Offset: 0x00019423
		public unsafe int MessageID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID)) = value;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x0011640C File Offset: 0x0011460C
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x0001B23E File Offset: 0x0001943E
		public unsafe string Text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x00116434 File Offset: 0x00114634
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x0001B25D File Offset: 0x0001945D
		public unsafe bool EndOfChain
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain)) = value;
			}
		}

		// Token: 0x04002131 RID: 8497
		private static readonly System.IntPtr NativeFieldInfoPtr_Sender;

		// Token: 0x04002132 RID: 8498
		private static readonly System.IntPtr NativeFieldInfoPtr_MessageID;

		// Token: 0x04002133 RID: 8499
		private static readonly System.IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002134 RID: 8500
		private static readonly System.IntPtr NativeFieldInfoPtr_EndOfChain;

		// Token: 0x04002135 RID: 8501
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0;

		// Token: 0x04002136 RID: 8502
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
