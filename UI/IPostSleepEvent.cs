using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200067D RID: 1661
	public class IPostSleepEvent : Il2CppObjectBase
	{
		// Token: 0x06009354 RID: 37716 RVA: 0x00263BFC File Offset: 0x00261DFC
		// Note: this type is marked as 'beforefieldinit'.
		static IPostSleepEvent()
		{
			Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "IPostSleepEvent");
			IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681643);
			IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681644);
			IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681645);
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x00263C60 File Offset: 0x00261E60
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x06009356 RID: 37718 RVA: 0x00263CA8 File Offset: 0x00261EA8
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x00263CF0 File Offset: 0x00261EF0
		[CallerCount(0)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x00046EE0 File Offset: 0x000450E0
		public IPostSleepEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040063A0 RID: 25504
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040063A1 RID: 25505
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040063A2 RID: 25506
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0;
	}
}
