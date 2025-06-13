using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000393 RID: 915
	public class IMessageEntity : Il2CppObjectBase
	{
		// Token: 0x06004643 RID: 17987 RVA: 0x0015BCA8 File Offset: 0x00159EA8
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageEntity()
		{
			Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "IMessageEntity");
			IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671956);
			IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671957);
			IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671958);
			IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671959);
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x0015BD20 File Offset: 0x00159F20
		// (set) Token: 0x06004645 RID: 17989 RVA: 0x0015BD6C File Offset: 0x00159F6C
		public unsafe virtual MSGConversation MsgConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x0015BDBC File Offset: 0x00159FBC
		[CallerCount(0)]
		public unsafe virtual void add_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x0015BE0C File Offset: 0x0015A00C
		[CallerCount(0)]
		public unsafe virtual void remove_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x000221B0 File Offset: 0x000203B0
		public IMessageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0;
	}
}
