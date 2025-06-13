using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000398 RID: 920
	public class SendableMessage : Il2CppSystem.Object
	{
		// Token: 0x06004726 RID: 18214 RVA: 0x0015F994 File Offset: 0x0015DB94
		// Note: this type is marked as 'beforefieldinit'.
		static SendableMessage()
		{
			Il2CppClassPointerStore<SendableMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "SendableMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr);
			SendableMessage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "Text");
			SendableMessage.NativeFieldInfoPtr_ShouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ShouldShowCheck");
			SendableMessage.NativeFieldInfoPtr_IsValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "IsValidCheck");
			SendableMessage.NativeFieldInfoPtr_onSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSelected");
			SendableMessage.NativeFieldInfoPtr_onSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSent");
			SendableMessage.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "conversation");
			SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "disableDefaultSendBehaviour");
			SendableMessage.NativeFieldInfoPtr_sentIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "sentIDs");
			SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100672124);
			SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100672125);
			SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100672126);
			SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100672127);
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0015FAB4 File Offset: 0x0015DCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162425, XrefRangeEnd = 162435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage(string text, MSGConversation conversation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0015FB14 File Offset: 0x0015DD14
		[CallerCount(0)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0015FB5C File Offset: 0x0015DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162435, XrefRangeEnd = 162439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0015FBC0 File Offset: 0x0015DDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162439, XrefRangeEnd = 162453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(bool network, int id = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref id;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x00022707 File Offset: 0x00020907
		public SendableMessage(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x0015FC18 File Offset: 0x0015DE18
		// (set) Token: 0x0600472D RID: 18221 RVA: 0x00022710 File Offset: 0x00020910
		public unsafe string Text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x0015FC40 File Offset: 0x0015DE40
		// (set) Token: 0x0600472F RID: 18223 RVA: 0x0002272F File Offset: 0x0002092F
		public unsafe SendableMessage.BoolCheck ShouldShowCheck
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.BoolCheck>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x0015FC70 File Offset: 0x0015DE70
		// (set) Token: 0x06004731 RID: 18225 RVA: 0x0002274E File Offset: 0x0002094E
		public unsafe SendableMessage.ValidityCheck IsValidCheck
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.ValidityCheck>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x0015FCA0 File Offset: 0x0015DEA0
		// (set) Token: 0x06004733 RID: 18227 RVA: 0x0002276D File Offset: 0x0002096D
		public unsafe Il2CppSystem.Action onSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x0015FCD0 File Offset: 0x0015DED0
		// (set) Token: 0x06004735 RID: 18229 RVA: 0x0002278C File Offset: 0x0002098C
		public unsafe Il2CppSystem.Action onSent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06004736 RID: 18230 RVA: 0x0015FD00 File Offset: 0x0015DF00
		// (set) Token: 0x06004737 RID: 18231 RVA: 0x000227AB File Offset: 0x000209AB
		public unsafe MSGConversation conversation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x0015FD30 File Offset: 0x0015DF30
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x000227CA File Offset: 0x000209CA
		public unsafe bool disableDefaultSendBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour)) = value;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x0015FD58 File Offset: 0x0015DF58
		// (set) Token: 0x0600473B RID: 18235 RVA: 0x000227E5 File Offset: 0x000209E5
		public unsafe List<int> sentIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FB6 RID: 12214
		private static readonly System.IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002FB7 RID: 12215
		private static readonly System.IntPtr NativeFieldInfoPtr_ShouldShowCheck;

		// Token: 0x04002FB8 RID: 12216
		private static readonly System.IntPtr NativeFieldInfoPtr_IsValidCheck;

		// Token: 0x04002FB9 RID: 12217
		private static readonly System.IntPtr NativeFieldInfoPtr_onSelected;

		// Token: 0x04002FBA RID: 12218
		private static readonly System.IntPtr NativeFieldInfoPtr_onSent;

		// Token: 0x04002FBB RID: 12219
		private static readonly System.IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x04002FBC RID: 12220
		private static readonly System.IntPtr NativeFieldInfoPtr_disableDefaultSendBehaviour;

		// Token: 0x04002FBD RID: 12221
		private static readonly System.IntPtr NativeFieldInfoPtr_sentIDs;

		// Token: 0x04002FBE RID: 12222
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x020009BE RID: 2494
		public sealed class BoolCheck : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CEB0 RID: 52912 RVA: 0x003224D4 File Offset: 0x003206D4
			// Note: this type is marked as 'beforefieldinit'.
			static BoolCheck()
			{
				Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "BoolCheck");
				SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100672128);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100672129);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100672130);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100672131);
			}

			// Token: 0x0600CEB1 RID: 52913 RVA: 0x00322548 File Offset: 0x00320748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162399, XrefRangeEnd = 162409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolCheck(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEB2 RID: 52914 RVA: 0x003225A4 File Offset: 0x003207A4
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CEB3 RID: 52915 RVA: 0x003225F4 File Offset: 0x003207F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(SendableMessage message, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CEB4 RID: 52916 RVA: 0x00322668 File Offset: 0x00320868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CEB5 RID: 52917 RVA: 0x00064358 File Offset: 0x00062558
			public BoolCheck(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CEB6 RID: 52918 RVA: 0x00064361 File Offset: 0x00062561
			public static implicit operator SendableMessage.BoolCheck(System.Func<SendableMessage, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<SendableMessage.BoolCheck>(A_0);
			}

			// Token: 0x0600CEB7 RID: 52919 RVA: 0x00064369 File Offset: 0x00062569
			public static SendableMessage.BoolCheck operator +(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<SendableMessage.BoolCheck>();
			}

			// Token: 0x0600CEB8 RID: 52920 RVA: 0x00064377 File Offset: 0x00062577
			public static SendableMessage.BoolCheck operator -(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<SendableMessage.BoolCheck>();
				}
				return result;
			}

			// Token: 0x04008BEB RID: 35819
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008BEC RID: 35820
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0;

			// Token: 0x04008BED RID: 35821
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0;

			// Token: 0x04008BEE RID: 35822
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x020009BF RID: 2495
		public sealed class ValidityCheck : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CEB9 RID: 52921 RVA: 0x003226B8 File Offset: 0x003208B8
			// Note: this type is marked as 'beforefieldinit'.
			static ValidityCheck()
			{
				Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ValidityCheck");
				SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100672132);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100672133);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100672134);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100672135);
			}

			// Token: 0x0600CEBA RID: 52922 RVA: 0x0032272C File Offset: 0x0032092C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 162419, RefRangeEnd = 162422, XrefRangeStart = 162409, XrefRangeEnd = 162419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidityCheck(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEBB RID: 52923 RVA: 0x00322788 File Offset: 0x00320988
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message, out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CEBC RID: 52924 RVA: 0x003227F0 File Offset: 0x003209F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162422, XrefRangeEnd = 162423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(SendableMessage message, out string invalidReason, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CEBD RID: 52925 RVA: 0x00322880 File Offset: 0x00320A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162423, XrefRangeEnd = 162425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string invalidReason, Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CEBE RID: 52926 RVA: 0x00064388 File Offset: 0x00062588
			public ValidityCheck(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008BEF RID: 35823
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008BF0 RID: 35824
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0;

			// Token: 0x04008BF1 RID: 35825
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0;

			// Token: 0x04008BF2 RID: 35826
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
