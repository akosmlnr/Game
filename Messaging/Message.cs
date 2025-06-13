using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000394 RID: 916
	[System.Serializable]
	public class Message : Il2CppSystem.Object
	{
		// Token: 0x06004649 RID: 17993 RVA: 0x0015BE5C File Offset: 0x0015A05C
		// Note: this type is marked as 'beforefieldinit'.
		static Message()
		{
			Il2CppClassPointerStore<Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message>.NativeClassPtr);
			Message.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "messageId");
			Message.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "text");
			Message.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "sender");
			Message.NativeFieldInfoPtr_endOfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "endOfGroup");
			Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671960);
			Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671961);
			Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671962);
			Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671963);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x0015BF2C File Offset: 0x0015A12C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 160383, RefRangeEnd = 160438, XrefRangeStart = 160382, XrefRangeEnd = 160383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x0015BF68 File Offset: 0x0015A168
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 160441, RefRangeEnd = 160450, XrefRangeStart = 160438, XrefRangeEnd = 160441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _endOfGroup;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _messageId;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x0015BFE0 File Offset: 0x0015A1E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160452, RefRangeEnd = 160453, XrefRangeStart = 160450, XrefRangeEnd = 160452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(TextMessageData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x0015C02C File Offset: 0x0015A22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160457, RefRangeEnd = 160458, XrefRangeStart = 160453, XrefRangeEnd = 160457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMessageData>(intPtr2) : null;
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x000221B9 File Offset: 0x000203B9
		public Message(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x0600464F RID: 17999 RVA: 0x0015C06C File Offset: 0x0015A26C
		// (set) Token: 0x06004650 RID: 18000 RVA: 0x000221C2 File Offset: 0x000203C2
		public unsafe int messageId
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId)) = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x0015C094 File Offset: 0x0015A294
		// (set) Token: 0x06004652 RID: 18002 RVA: 0x000221DD File Offset: 0x000203DD
		public unsafe string text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x0015C0BC File Offset: 0x0015A2BC
		// (set) Token: 0x06004654 RID: 18004 RVA: 0x000221FC File Offset: 0x000203FC
		public unsafe Message.ESenderType sender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender)) = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x0015C0E4 File Offset: 0x0015A2E4
		// (set) Token: 0x06004656 RID: 18006 RVA: 0x00022217 File Offset: 0x00020417
		public unsafe bool endOfGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup)) = value;
			}
		}

		// Token: 0x04002F0E RID: 12046
		private static readonly System.IntPtr NativeFieldInfoPtr_messageId;

		// Token: 0x04002F0F RID: 12047
		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002F10 RID: 12048
		private static readonly System.IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002F11 RID: 12049
		private static readonly System.IntPtr NativeFieldInfoPtr_endOfGroup;

		// Token: 0x04002F12 RID: 12050
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F13 RID: 12051
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0;

		// Token: 0x04002F14 RID: 12052
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0;

		// Token: 0x04002F15 RID: 12053
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0;

		// Token: 0x020009B5 RID: 2485
		[OriginalName("Assembly-CSharp.dll", "", "ESenderType")]
		public enum ESenderType
		{
			// Token: 0x04008BC2 RID: 35778
			Player,
			// Token: 0x04008BC3 RID: 35779
			Other
		}
	}
}
