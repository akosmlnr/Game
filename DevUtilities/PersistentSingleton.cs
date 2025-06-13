using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000485 RID: 1157
	public class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x06006378 RID: 25464 RVA: 0x001C744C File Offset: 0x001C564C
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentSingleton()
		{
			Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PersistentSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr);
			PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100676035);
			PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100676036);
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x001C74E0 File Offset: 0x001C56E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 205555, RefRangeEnd = 205565, XrefRangeStart = 205547, XrefRangeEnd = 205555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x001C751C File Offset: 0x001C571C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 205566, RefRangeEnd = 205577, XrefRangeStart = 205565, XrefRangeEnd = 205566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x0002EC79 File Offset: 0x0002CE79
		public PersistentSingleton(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040043E1 RID: 17377
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040043E2 RID: 17378
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
