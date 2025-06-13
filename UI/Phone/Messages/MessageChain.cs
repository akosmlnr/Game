using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D6 RID: 1750
	[System.Serializable]
	public class MessageChain : Il2CppSystem.Object
	{
		// Token: 0x06009C9A RID: 40090 RVA: 0x0027F754 File Offset: 0x0027D954
		// Note: this type is marked as 'beforefieldinit'.
		static MessageChain()
		{
			Il2CppClassPointerStore<MessageChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageChain>.NativeClassPtr);
			MessageChain.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "Messages");
			MessageChain.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "id");
			MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100682678);
			MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100682679);
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x0027F7D4 File Offset: 0x0027D9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278679, XrefRangeEnd = 278695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MessageChain Combine(MessageChain a, MessageChain b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x0027F82C File Offset: 0x0027DA2C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278703, RefRangeEnd = 278712, XrefRangeStart = 278695, XrefRangeEnd = 278703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageChain>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x0004C3F8 File Offset: 0x0004A5F8
		public MessageChain(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x0027F868 File Offset: 0x0027DA68
		// (set) Token: 0x06009C9F RID: 40095 RVA: 0x0004C401 File Offset: 0x0004A601
		public unsafe List<string> Messages
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x06009CA0 RID: 40096 RVA: 0x0027F898 File Offset: 0x0027DA98
		// (set) Token: 0x06009CA1 RID: 40097 RVA: 0x0004C420 File Offset: 0x0004A620
		public unsafe int id
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04006965 RID: 26981
		private static readonly System.IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x04006966 RID: 26982
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04006967 RID: 26983
		private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0;

		// Token: 0x04006968 RID: 26984
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
