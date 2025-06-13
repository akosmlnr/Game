using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A2 RID: 674
	[Serializable]
	public class MSGConversationData : SaveData
	{
		// Token: 0x06003146 RID: 12614 RVA: 0x00110BC4 File Offset: 0x0010EDC4
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversationData()
		{
			Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MSGConversationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr);
			MSGConversationData.NativeFieldInfoPtr_ConversationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ConversationIndex");
			MSGConversationData.NativeFieldInfoPtr_Read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "Read");
			MSGConversationData.NativeFieldInfoPtr_MessageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "MessageHistory");
			MSGConversationData.NativeFieldInfoPtr_ActiveResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ActiveResponses");
			MSGConversationData.NativeFieldInfoPtr_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "IsHidden");
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100669039);
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100669040);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00110C80 File Offset: 0x0010EE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136836, RefRangeEnd = 136837, XrefRangeStart = 136833, XrefRangeEnd = 136836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData(int conversationIndex, bool read, Il2CppReferenceArray<TextMessageData> messageHistory, Il2CppReferenceArray<TextResponseData> activeResponses, bool isHidden) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref conversationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageHistory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeResponses);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHidden;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x00110D08 File Offset: 0x0010EF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136846, RefRangeEnd = 136847, XrefRangeStart = 136837, XrefRangeEnd = 136846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00019E25 File Offset: 0x00018025
		public MSGConversationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x00110D44 File Offset: 0x0010EF44
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x00019E2E File Offset: 0x0001802E
		public unsafe int ConversationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex)) = value;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x00110D6C File Offset: 0x0010EF6C
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x00019E49 File Offset: 0x00018049
		public unsafe bool Read
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read)) = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x00110D94 File Offset: 0x0010EF94
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x00019E64 File Offset: 0x00018064
		public unsafe Il2CppReferenceArray<TextMessageData> MessageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMessageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x00110DC4 File Offset: 0x0010EFC4
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x00019E83 File Offset: 0x00018083
		public unsafe Il2CppReferenceArray<TextResponseData> ActiveResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextResponseData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x00110DF4 File Offset: 0x0010EFF4
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x00019EA2 File Offset: 0x000180A2
		public unsafe bool IsHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden)) = value;
			}
		}

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeFieldInfoPtr_ConversationIndex;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_Read;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_MessageHistory;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_ActiveResponses;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_IsHidden;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
